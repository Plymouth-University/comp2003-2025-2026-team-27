using Lms.Data;
using Lms.Data.Models.Delib;
using LmsModernApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LmsModernApp.Controllers
{
    [Authorize(AuthenticationSchemes = "StaffAuth")]
    public class UsersController : Controller
    {
        private readonly IBorrowerRepository _borrowerRepository;
        private readonly IOperatorRepository _operatorRepository;

        public UsersController(IBorrowerRepository borrowerRepository, IOperatorRepository operatorRepository)
        {
            _borrowerRepository = borrowerRepository;
            _operatorRepository = operatorRepository;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var model = new BorrowerMaintenanceViewModel();
            await PopulateLookupsAsync(model);

            if (id.HasValue)
            {
                HttpContext.Session.SetInt32("SelectedBorrowerId", id.Value);
            }

            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (selectedId.HasValue)
            {
                var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
                if (borrower != null)
                {
                    model.Borrower = borrower;
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Query(BorrowerMaintenanceViewModel model)
        {
            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
            if (op == null) return Unauthorized();

            var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op);
            
            // Extract search criteria from the model (which uses the Borrower object as a container)
            var criteria = new BorrowerSearchCriteria
            {
                BorBarNo = model.Borrower.BorBarNo,
                BorSurname = model.Borrower.BorSurname,
                BorGiven = model.Borrower.BorGiven,
                BorType = model.Borrower.BorType,
                BorGroup = model.Borrower.BorGroup,
                BorClass = model.Borrower.BorClass,
                BorStatus = model.Borrower.BorStatus,
                BorLocation = model.Borrower.BorLocation,
                BorSex = model.Borrower.BorSex,
                BorDob = model.Borrower.BorDob.HasValue ? model.Borrower.BorDob.Value.ToDateTime(TimeOnly.MinValue) : null,
                // Condition would need to come from a separate field in a real search model
                BorDobCondition = Request.Form["BorDobCondition"].ToString() ?? "equal"
            };

            Lms.Data.PagedResult<Lms.Data.BorrowerWithAddress> results = await _borrowerRepository.SearchBorrowersAsync(
                criteria.BorBarNo, criteria.BorSurname, criteria.BorGiven, criteria.BorType, criteria.BorGroup,
                criteria.BorClass, criteria.BorStatus, criteria.BorLocation, criteria.BorSex, criteria.BorDob,
                criteria.BorDobCondition, criteria.FileNumber, allowedGroups, 1, 100, "BorSurname", "ASC");

            if (results.TotalItems == 0)
            {
                TempData["ErrorMessage"] = "No borrowers found matching your criteria.";
                return RedirectToAction(nameof(Index));
            }
            
            if (results.TotalItems == 1)
            {
                HttpContext.Session.SetInt32("SelectedBorrowerId", results.Items[0].Borrower.BorNo);
                return RedirectToAction(nameof(Index));
            }

            // Store criteria in session for the table view
            TempData["SearchCriteria"] = System.Text.Json.JsonSerializer.Serialize(criteria);
            
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        public async Task<IActionResult> BorrowerResultTable(int page = 1, string sort = "BorSurname", string order = "ASC")
        {
            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
            if (op == null) return Unauthorized();

            var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op);

            // Retrieve full criteria from TempData
            var criteriaJson = TempData.Peek("SearchCriteria")?.ToString();
            var criteria = !string.IsNullOrEmpty(criteriaJson) 
                ? System.Text.Json.JsonSerializer.Deserialize<BorrowerSearchCriteria>(criteriaJson)
                : new BorrowerSearchCriteria();

            if (criteria == null) criteria = new BorrowerSearchCriteria();

            Lms.Data.PagedResult<Lms.Data.BorrowerWithAddress> results = await _borrowerRepository.SearchBorrowersAsync(
                criteria.BorBarNo, criteria.BorSurname, criteria.BorGiven, criteria.BorType, criteria.BorGroup,
                criteria.BorClass, criteria.BorStatus, criteria.BorLocation, criteria.BorSex, criteria.BorDob,
                criteria.BorDobCondition, criteria.FileNumber, allowedGroups, page, 20, sort, order);

            return View(results);
        }

        [HttpPost]
        public async Task<IActionResult> Search(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode))
            {
                return RedirectToAction(nameof(Index));
            }

            var borrower = await _borrowerRepository.GetBorrowerByBarcodeAsync(barcode);
            if (borrower != null)
            {
                HttpContext.Session.SetInt32("SelectedBorrowerId", borrower.BorNo);
            }
            else
            {
                TempData["ErrorMessage"] = "Borrower not found.";
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(BorrowerMaintenanceViewModel model)
        {
            // Mandatory Field Validation
            if (string.IsNullOrWhiteSpace(model.Borrower.BorBarNo))
                ModelState.AddModelError("Borrower.BorBarNo", "Barcode is required.");
            if (string.IsNullOrWhiteSpace(model.Borrower.BorSurname))
                ModelState.AddModelError("Borrower.BorSurname", "Surname is required.");
            if (string.IsNullOrWhiteSpace(model.Borrower.BorGiven))
                ModelState.AddModelError("Borrower.BorGiven", "Given Name is required.");
            if (string.IsNullOrWhiteSpace(model.Borrower.BorLocation))
                ModelState.AddModelError("Borrower.BorLocation", "Location is required.");

            if (ModelState.IsValid)
            {
                var success = await _borrowerRepository.SaveBorrowerAsync(model.Borrower);
                if (success)
                {
                    HttpContext.Session.SetInt32("SelectedBorrowerId", model.Borrower.BorNo);
                    TempData["SuccessMessage"] = "Borrower saved successfully.";
                    return RedirectToAction(nameof(Index), new { id = model.Borrower.BorNo });
                }
                TempData["ErrorMessage"] = "Error saving borrower to database.";
            }

            await PopulateLookupsAsync(model);
            return View("Index", model);
        }

        public IActionResult Clear()
        {
            HttpContext.Session.Remove("SelectedBorrowerId");
            TempData.Remove("SearchCriteria");
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var success = await _borrowerRepository.DeleteBorrowerAsync(id);
            if (success)
            {
                HttpContext.Session.Remove("SelectedBorrowerId");
                TempData["SuccessMessage"] = "Borrower deleted successfully.";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["ErrorMessage"] = "Could not delete borrower. Ensure they have no active loans.";
                return RedirectToAction(nameof(Index), new { id = id });
            }
        }

        private async Task PopulateLookupsAsync(BorrowerMaintenanceViewModel model)
        {
            model.BorrowerTypes = await _borrowerRepository.GetBorrowerTypesAsync();
            model.BorrowerGroups = await _borrowerRepository.GetBorrowerGroupsAsync();
            model.BorrowerClasses = await _borrowerRepository.GetBorrowerClassesAsync();
            model.BorrowerStatuses = await _borrowerRepository.GetBorrowerStatusesAsync();
            model.Locations = await _borrowerRepository.GetLocationsAsync();
            model.Titles = await _borrowerRepository.GetTitlesAsync();
            model.Areas = await _borrowerRepository.GetAreasAsync();
            model.Wards = await _borrowerRepository.GetWardsAsync();
        }

        public IActionResult AdvancedSearch()
        {
            return View();
        }

        public async Task<IActionResult> FileList(string? creator, int page = 1, string sortBy = "FileDesc", string sortOrder = "ASC", string? searchTerm = null)
        {
            var currentOperator = User.Identity?.Name ?? "UNKNOWN";
            var selectedCreator = creator ?? currentOperator;
            var pageSize = 10;

            // Use the improved Repository method with live paging and sorting
            var result = await _borrowerRepository.GetFileSetsByCreatorAsync(selectedCreator, page, pageSize, sortBy, sortOrder, searchTerm);
            
            var allOperators = await _operatorRepository.GetAllOperatorsAsync();
            var operatorsLookup = allOperators.Select(o => new LookupItem { Code = o.OperName, Name = o.OperName }).ToList();
            operatorsLookup.Insert(0, new LookupItem { Code = "SYSGLOBALFILES", Name = "Global Files" });

            var model = new BorrowerFileListViewModel
            {
                SelectedOperator = selectedCreator,
                Operators = operatorsLookup,
                FileSets = result.Items,
                CurrentPage = page,
                TotalPages = result.TotalPages,
                SortBy = sortBy,
                SortOrder = sortOrder,
                SearchTerm = searchTerm
            };

            var selectedId = HttpContext.Session.GetInt32("SelectedFileNumber");
            if (selectedId.HasValue)
            {
                var selectedSet = await _borrowerRepository.GetFileSetByNumberAsync(selectedId.Value);
                if (selectedSet != null)
                {
                    model.SelectedFileSet = selectedSet;
                    model.CanEdit = selectedSet.FileOper == currentOperator || selectedSet.FileOperAccess == "A";
                    model.CanDelete = selectedSet.FileOper == currentOperator;
                    model.RelatedReadingListLinks = await _borrowerRepository.GetRelatedReadingListsAsync(selectedId.Value);
                }
            }

            model.GeneralReadingLists = await _borrowerRepository.GetGeneralCatalogFilesAsync();
            return View(model);
        }

        public async Task<IActionResult> QueryFile(int id)
        {
            var criteria = new BorrowerSearchCriteria
            {
                FileNumber = id
            };
            
            TempData["SearchCriteria"] = System.Text.Json.JsonSerializer.Serialize(criteria);
            
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        [HttpPost]
        public async Task<IActionResult> SaveReadingListLinks(int borrowerFileNumber, List<int> selectedCatFileNumbers, List<DateTime> expiryDates)
        {
            var links = new List<AFileSetLibCat>();
            if (selectedCatFileNumbers != null)
            {
                for (int i = 0; i < selectedCatFileNumbers.Count; i++)
                {
                    links.Add(new AFileSetLibCat
                    {
                        FileNumberCat = selectedCatFileNumbers[i],
                        ExpirationDate = expiryDates[i],
                        LastModifyBy = User.Identity?.Name ?? "SYSTEM",
                        LastModifyOn = DateTime.Now
                    });
                }
            }

            await _borrowerRepository.SaveRelatedReadingListsAsync(borrowerFileNumber, links);
            TempData["SuccessMessage"] = "Reading list relationships updated.";
            return RedirectToAction(nameof(FileList));
        }

        [HttpPost]
        public IActionResult SelectFileSet(int fileNumber, int page = 1)
        {
            HttpContext.Session.SetInt32("SelectedFileNumber", fileNumber);
            return RedirectToAction(nameof(FileList), new { page });
        }

        public IActionResult ClearFileSet()
        {
            HttpContext.Session.Remove("SelectedFileNumber");
            return RedirectToAction(nameof(FileList));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateFileSet(BorrowerFileListViewModel model)
        {
            var operatorName = User.Identity?.Name ?? "UNKNOWN";
            var existing = await _borrowerRepository.GetFileSetByNumberAsync(model.SelectedFileSet.FileNumber ?? 0);
            
            if (existing != null && (existing.FileOper == operatorName || existing.FileOperAccess == "A"))
            {
                existing.FileDesc = model.SelectedFileSet.FileDesc;
                existing.FileOperAccess = model.SelectedFileSet.FileOperAccess;
                
                var success = await _borrowerRepository.SaveFileSetNameAsync(existing);
                if (success) TempData["SuccessMessage"] = "File set updated.";
                else TempData["ErrorMessage"] = "Error updating file set.";
            }
            
            return RedirectToAction(nameof(FileList), new { page = model.CurrentPage });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EmptyFileSet(int fileNumber, int page = 1)
        {
            var operatorName = User.Identity?.Name ?? "UNKNOWN";
            var existing = await _borrowerRepository.GetFileSetByNumberAsync(fileNumber);
            
            if (existing != null && existing.FileOper == operatorName)
            {
                await _borrowerRepository.EmptyFileSetAsync(fileNumber);
                TempData["SuccessMessage"] = "File set emptied.";
            }
            
            return RedirectToAction(nameof(FileList), new { page });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFileSet(int fileNumber, int page = 1)
        {
            var operatorName = User.Identity?.Name ?? "UNKNOWN";
            var existing = await _borrowerRepository.GetFileSetByNumberAsync(fileNumber);
            
            if (existing != null && existing.FileOper == operatorName)
            {
                await _borrowerRepository.DeleteFileSetAsync(fileNumber);
                HttpContext.Session.Remove("SelectedFileNumber");
                TempData["SuccessMessage"] = "File set deleted.";
            }
            
            return RedirectToAction(nameof(FileList), new { page });
        }

        public IActionResult ReadingList()
        {
            return View();
        }

        public IActionResult Import()
        {
            return View();
        }
    }
}
