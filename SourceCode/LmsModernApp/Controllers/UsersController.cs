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
                await PrepareNavigationListAsync();
            }

            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (selectedId.HasValue)
            {
                var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
                if (borrower != null)
                {
                    model.Borrower = borrower;
                    HttpContext.Session.SetString("SelectedBorrowerBarcode", borrower.BorBarNo ?? "");
                }
            }

            return View(model);
        }

        private async Task PrepareNavigationListAsync()
        {
            var criteriaJson = HttpContext.Session.GetString("SearchCriteria");
            if (string.IsNullOrEmpty(criteriaJson)) return;

            var existingNavJson = HttpContext.Session.GetString("NavigationIds");
            if (!string.IsNullOrEmpty(existingNavJson)) return;

            var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var criteria = System.Text.Json.JsonSerializer.Deserialize<BorrowerSearchCriteria>(criteriaJson, options);
            if (criteria == null) return;

            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
            var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op!);

            var results = await _borrowerRepository.SearchBorrowersAsync(
                criteria.BorBarNo, criteria.BorSurname, criteria.BorGiven, criteria.BorType, criteria.BorGroup,
                criteria.BorClass, criteria.BorStatus, criteria.BorLocation, criteria.BorSex, criteria.BorDob,
                criteria.BorDobCondition, criteria.FileNumber, allowedGroups, 1, 5000, criteria.SortField ?? "BorSurname", criteria.SortOrder ?? "ASC");

            var ids = results.Items.Select(i => i.Borrower.BorNo).ToList();
            HttpContext.Session.SetString("NavigationIds", System.Text.Json.JsonSerializer.Serialize(ids));
        }

        public IActionResult First()
        {
            var idsJson = HttpContext.Session.GetString("NavigationIds");
            if (!string.IsNullOrEmpty(idsJson))
            {
                var ids = System.Text.Json.JsonSerializer.Deserialize<List<int>>(idsJson);
                if (ids != null && ids.Any()) return RedirectToAction(nameof(Index), new { id = ids.First() });
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Last()
        {
            var idsJson = HttpContext.Session.GetString("NavigationIds");
            if (!string.IsNullOrEmpty(idsJson))
            {
                var ids = System.Text.Json.JsonSerializer.Deserialize<List<int>>(idsJson);
                if (ids != null && ids.Any()) return RedirectToAction(nameof(Index), new { id = ids.Last() });
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Next()
        {
            var currentId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            var idsJson = HttpContext.Session.GetString("NavigationIds");
            if (currentId.HasValue && !string.IsNullOrEmpty(idsJson))
            {
                var ids = System.Text.Json.JsonSerializer.Deserialize<List<int>>(idsJson);
                if (ids != null)
                {
                    var index = ids.IndexOf(currentId.Value);
                    if (index >= 0 && index < ids.Count - 1) return RedirectToAction(nameof(Index), new { id = ids[index + 1] });
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Prev()
        {
            var currentId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            var idsJson = HttpContext.Session.GetString("NavigationIds");
            if (currentId.HasValue && !string.IsNullOrEmpty(idsJson))
            {
                var ids = System.Text.Json.JsonSerializer.Deserialize<List<int>>(idsJson);
                if (ids != null)
                {
                    var index = ids.IndexOf(currentId.Value);
                    if (index > 0) return RedirectToAction(nameof(Index), new { id = ids[index - 1] });
                }
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Query(BorrowerMaintenanceViewModel model)
        {
            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
            if (op == null) return Unauthorized();

            var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op);

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
                BorDobCondition = Request.Form["BorDobCondition"].ToString() ?? "equal"
            };

            var results = await _borrowerRepository.SearchBorrowersAsync(
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
                var borrower = results.Items[0].Borrower;
                HttpContext.Session.SetInt32("SelectedBorrowerId", borrower.BorNo);
                HttpContext.Session.SetString("SelectedBorrowerBarcode", borrower.BorBarNo ?? "");
                return RedirectToAction(nameof(Index));
            }

            HttpContext.Session.SetString("SearchCriteria", System.Text.Json.JsonSerializer.Serialize(criteria));

            return RedirectToAction(nameof(BorrowerResultTable));
        }

        public async Task<IActionResult> BorrowerResultTable(int page = 1, string sort = "BorSurname", string order = "ASC")
        {
            var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
            if (op == null) return Unauthorized();

            var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op);

            var criteriaJson = HttpContext.Session.GetString("SearchCriteria");
            var options = new System.Text.Json.JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var criteria = !string.IsNullOrEmpty(criteriaJson)
                ? System.Text.Json.JsonSerializer.Deserialize<BorrowerSearchCriteria>(criteriaJson, options)
                : new BorrowerSearchCriteria();

            if (criteria == null) criteria = new BorrowerSearchCriteria();

            var results = await _borrowerRepository.SearchBorrowersAsync(
                criteria.BorBarNo, criteria.BorSurname, criteria.BorGiven, criteria.BorType, criteria.BorGroup,
                criteria.BorClass, criteria.BorStatus, criteria.BorLocation, criteria.BorSex, criteria.BorDob,
                criteria.BorDobCondition, criteria.FileNumber, allowedGroups, page, 20, sort, order);

            if (criteria.FileNumber.HasValue && criteria.FileNumber > 0)
            {
                var fileSet = await _borrowerRepository.GetFileSetByNumberAsync(criteria.FileNumber.Value);
                if (fileSet != null)
                {
                    ViewBag.CurrentFileDesc = fileSet.FileDesc;
                    TempData["CanRemoveFromFile"] = true;
                }
            }
            else
            {
                TempData["CanRemoveFromFile"] = false;
            }

            ViewBag.WritableFileSets = await _borrowerRepository.GetWritableFileSetsAsync(op.OperName);
            ViewBag.CurrentFileNumber = criteria.FileNumber;

            return View(results);
        }

        [HttpPost]
        public async Task<IActionResult> AddMarkedToFile(int fileNumber, List<int> selectedBorrowerIds)
        {
            if (fileNumber > 0 && selectedBorrowerIds != null && selectedBorrowerIds.Any())
            {
                var count = await _borrowerRepository.AddBorrowersToFileAsync(fileNumber, selectedBorrowerIds);
                TempData["SuccessMessage"] = $"Successfully added {count} borrowers to the file.";
            }
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMarked(List<int> selectedBorrowerIds)
        {
            if (selectedBorrowerIds != null && selectedBorrowerIds.Any())
            {
                int successCount = 0;
                int failCount = 0;
                foreach (var id in selectedBorrowerIds)
                {
                    var success = await _borrowerRepository.DeleteBorrowerAsync(id);
                    if (success) successCount++;
                    else failCount++;
                }

                if (failCount == 0) TempData["SuccessMessage"] = $"Successfully deleted {successCount} borrowers.";
                else TempData["ErrorMessage"] = $"Deleted {successCount} borrowers. {failCount} could not be deleted (likely due to active loans).";
            }
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        [HttpPost]
        public async Task<IActionResult> SaveAllToFile(int fileNumber)
        {
            if (fileNumber > 0)
            {
                var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
                if (op == null) return Unauthorized();
                var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op);

                var criteriaJson = HttpContext.Session.GetString("SearchCriteria");
                var criteria = !string.IsNullOrEmpty(criteriaJson)
                    ? System.Text.Json.JsonSerializer.Deserialize<BorrowerSearchCriteria>(criteriaJson)
                    : new BorrowerSearchCriteria();

                if (criteria == null) criteria = new BorrowerSearchCriteria();

                var allResults = await _borrowerRepository.SearchBorrowersAsync(
                    criteria.BorBarNo, criteria.BorSurname, criteria.BorGiven, criteria.BorType, criteria.BorGroup,
                    criteria.BorClass, criteria.BorStatus, criteria.BorLocation, criteria.BorSex, criteria.BorDob,
                    criteria.BorDobCondition, criteria.FileNumber, allowedGroups, 1, 10000, "BorSurname", "ASC");

                var allIds = allResults.Items.Select(i => i.Borrower.BorNo).ToList();
                if (allIds.Any())
                {
                    var count = await _borrowerRepository.AddBorrowersToFileAsync(fileNumber, allIds);
                    TempData["SuccessMessage"] = $"Successfully added all {count} matching borrowers to the file.";
                }
            }
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveMarkedFromFile(int fileNumber, List<int> selectedBorrowerIds)
        {
            if (fileNumber > 0 && selectedBorrowerIds != null && selectedBorrowerIds.Any())
            {
                var count = await _borrowerRepository.RemoveBorrowersFromFileAsync(fileNumber, selectedBorrowerIds);
                TempData["SuccessMessage"] = $"Successfully removed {count} borrowers from the file.";
            }
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveAllFromFile(int fileNumber)
        {
            if (fileNumber > 0)
            {
                var op = await _operatorRepository.GetOperatorByNameAsync(User.Identity?.Name ?? "");
                if (op == null) return Unauthorized();
                var allowedGroups = await _operatorRepository.GetAllowedGroupsAsync(op);

                var results = await _borrowerRepository.SearchBorrowersAsync(
                    null, null, null, null, null, null, null, null, null, null, null,
                    fileNumber, allowedGroups, 1, 10000, "BorSurname", "ASC");

                var allIds = results.Items.Select(i => i.Borrower.BorNo).ToList();
                if (allIds.Any())
                {
                    var count = await _borrowerRepository.RemoveBorrowersFromFileAsync(fileNumber, allIds);
                    TempData["SuccessMessage"] = $"Successfully removed all {count} borrowers from the file.";
                }
            }
            return RedirectToAction(nameof(BorrowerResultTable));
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
                HttpContext.Session.SetString("SelectedBorrowerBarcode", borrower.BorBarNo ?? "");
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
                    HttpContext.Session.SetString("SelectedBorrowerBarcode", model.Borrower.BorBarNo ?? "");
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
            HttpContext.Session.Remove("SelectedBorrowerBarcode");
            HttpContext.Session.Remove("SearchCriteria");
            HttpContext.Session.Remove("NavigationIds");
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
                HttpContext.Session.Remove("SelectedBorrowerBarcode");
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

            HttpContext.Session.SetString("SearchCriteria", System.Text.Json.JsonSerializer.Serialize(criteria));

            return RedirectToAction(nameof(BorrowerResultTable));
        }

        [HttpPost]
        public async Task<IActionResult> SaveReadingListLinks(int borrowerFileNumber, List<int> selectedCatFileNumbers)
        {
            var links = new List<AFileSetLibCat>();
            if (selectedCatFileNumbers != null)
            {
                foreach (var catNo in selectedCatFileNumbers)
                {
                    var dateStr = Request.Form[$"expiryDate_{catNo}"].ToString();
                    DateTime expiryDate = DateTime.MaxValue;

                    if (DateTime.TryParse(dateStr, out var parsedDate))
                    {
                        expiryDate = parsedDate;
                    }

                    links.Add(new AFileSetLibCat
                    {
                        FileNumberCat = catNo,
                        ExpirationDate = expiryDate,
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

        public async Task<IActionResult> ReadingList()
        {
            var borrowerBarcode = HttpContext.Session.GetString("SelectedBorrowerBarcode");

            if (string.IsNullOrWhiteSpace(borrowerBarcode))
            {
                TempData["ErrorMessage"] = "Please select a borrower first.";
                return RedirectToAction(nameof(Index));
            }

            var items = await _borrowerRepository.GetBorrowerReadingListAsync(borrowerBarcode);
            return View(items);
        }

        public IActionResult Import()
        {
            return View();
        }
    }
}