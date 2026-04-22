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
                    await PopulateAddressesAsync(model);
                    ViewBag.MemoCount = await _borrowerRepository.GetMemoCountAsync(selectedId.Value);
                }
            }

            return View(model);
        }

        private async Task PopulateAddressesAsync(BorrowerMaintenanceViewModel model)
        {
            if (model.Borrower.BorNo > 0)
            {
                var mainAddr = await _borrowerRepository.GetMainAddressAsync(model.Borrower.BorNo);
                if (mainAddr != null)
                {
                    model.CorrespondenceAddress = FormatAddress(mainAddr.BaAddr1, mainAddr.BaAddr2, mainAddr.BaSuburbCd, mainAddr.BaPcode);
                }
                else
                {
                    model.CorrespondenceAddress = model.Borrower.BorAddr1Txt;
                }

                model.ResidentialAddress = model.Borrower.BorAddr2Txt;
                model.GuardianAddress = model.Borrower.BorAddr3Txt;
            }
        }

        private string FormatAddress(params string?[] parts)
        {
            return string.Join(", ", parts.Where(p => !string.IsNullOrWhiteSpace(p)));
        }

        private async Task PrepareNavigationListAsync()
        {
            var criteriaJson = HttpContext.Session.GetString("SearchCriteria");
            if (string.IsNullOrEmpty(criteriaJson)) return;

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
                HttpContext.Session.SetInt32("SelectedBorrowerId", results.Items[0].Borrower.BorNo);
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
            if (string.IsNullOrWhiteSpace(barcode)) return RedirectToAction(nameof(Index));

            var borrower = await _borrowerRepository.GetBorrowerByBarcodeAsync(barcode);
            if (borrower != null) HttpContext.Session.SetInt32("SelectedBorrowerId", borrower.BorNo);
            else TempData["ErrorMessage"] = "Borrower not found.";

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Save(BorrowerMaintenanceViewModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Borrower.BorBarNo)) ModelState.AddModelError("Borrower.BorBarNo", "Barcode is required.");
            if (string.IsNullOrWhiteSpace(model.Borrower.BorSurname)) ModelState.AddModelError("Borrower.BorSurname", "Surname is required.");
            if (string.IsNullOrWhiteSpace(model.Borrower.BorGiven)) ModelState.AddModelError("Borrower.BorGiven", "Given Name is required.");
            if (string.IsNullOrWhiteSpace(model.Borrower.BorLocation)) ModelState.AddModelError("Borrower.BorLocation", "Location is required.");

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
            await PopulateAddressesAsync(model);
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
            TempData["ErrorMessage"] = "Could not delete borrower. Ensure they have no active loans.";
            return RedirectToAction(nameof(Index), new { id = id });
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
            model.Suburbs = await _borrowerRepository.GetSuburbsAsync();
            model.AddressTypes = await _borrowerRepository.GetAddressTypesAsync();
        }

        public IActionResult AdvancedSearch() => View();

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
            var criteria = new BorrowerSearchCriteria { FileNumber = id };
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
                    DateTime expiryDate = DateTime.TryParse(dateStr, out var parsedDate) ? parsedDate : DateTime.MaxValue;
                    links.Add(new AFileSetLibCat { FileNumberCat = catNo, ExpirationDate = expiryDate, LastModifyBy = User.Identity?.Name ?? "SYSTEM", LastModifyOn = DateTime.Now });
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
                await _borrowerRepository.SaveFileSetNameAsync(existing);
                TempData["SuccessMessage"] = "File set updated.";
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

        public IActionResult ReadingList() => View();

        public async Task<IActionResult> Addresses(int? borNo, string? type)
        {
            if (borNo.HasValue) HttpContext.Session.SetInt32("SelectedBorrowerId", borNo.Value);
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            var model = new BorrowerMaintenanceViewModel();
            await PopulateLookupsAsync(model);

            if (selectedId.HasValue)
            {
                var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
                if (borrower != null)
                {
                    model.Borrower = borrower;
                    model.Addresses = await _borrowerRepository.GetBorrowerAddressesAsync(selectedId.Value);
                    if (type == "Correspondence") {
                        var main = await _borrowerRepository.GetMainAddressAsync(selectedId.Value);
                        model.SelectedAddress = main ?? new BorAddr { BaAddr1 = borrower.BorAddr1Txt, BaAddressTypeId = 0 };
                    }
                    else if (type == "Residential") model.SelectedAddress = new BorAddr { BaAddr1 = borrower.BorAddr2Txt, BaAddressTypeId = 1 };
                    else if (type == "Guardian") model.SelectedAddress = new BorAddr { BaAddr1 = borrower.BorAddr3Txt, BaAddressTypeId = 2 };
                }
            }
            return View(model);
        }

        public async Task<IActionResult> UsersMoreOptions()
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            var model = new BorrowerMaintenanceViewModel();
            await PopulateLookupsAsync(model);

            if (selectedId.HasValue)
            {
                var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
                if (borrower != null)
                {
                    model.Borrower = borrower;
                    await PopulateAddressesAsync(model);
                    ViewBag.MemoCount = await _borrowerRepository.GetMemoCountAsync(selectedId.Value);
                    if (!string.IsNullOrEmpty(borrower.BorBarNo)) {
                        var onLoan = await _borrowerRepository.GetItemsOnLoanAsync(borrower.BorBarNo);
                        model.Borrower.BorNoLoans = onLoan.Count(s => s.StkIsOnLoan == "Y");
                    }
                }
            }
            return View(model);
        }

        [HttpPost] public async Task<IActionResult> ApproveBorrower(int id) { await _borrowerRepository.ApproveRegistrationAsync(id); return RedirectToAction(nameof(UsersMoreOptions)); }
        [HttpPost] public async Task<IActionResult> RejectBorrower(int id) { await _borrowerRepository.RejectRegistrationAsync(id); return RedirectToAction(nameof(UsersMoreOptions)); }
        [HttpPost] public async Task<IActionResult> ResetBorrowerPin(string barcode) { await _borrowerRepository.ResetPinAsync(barcode); return RedirectToAction(nameof(UsersMoreOptions)); }
        [HttpPost] public async Task<IActionResult> SetAsParent(int id) { await _borrowerRepository.SetRelationshipAsync(id, null, "P"); return RedirectToAction(nameof(UsersMoreOptions)); }
        [HttpPost] public async Task<IActionResult> BreakRelationship(int id) { await _borrowerRepository.SetRelationshipAsync(id, null, "N"); return RedirectToAction(nameof(UsersMoreOptions)); }

        public async Task<IActionResult> SelectFileForBorrower(bool isRemove)
        {
            ViewBag.IsRemove = isRemove;
            ViewBag.Files = await _borrowerRepository.GetWritableFileSetsAsync(User.Identity?.Name ?? "UNKNOWN");
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            return View(await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value));
        }

        [HttpPost]
        public async Task<IActionResult> ProcessFileOperation(int fileNumber, int borNo, bool isRemove)
        {
            if (isRemove) await _borrowerRepository.RemoveBorrowersFromFileAsync(fileNumber, new List<int> { borNo });
            else await _borrowerRepository.AddBorrowersToFileAsync(fileNumber, new List<int> { borNo });
            return RedirectToAction(nameof(UsersMoreOptions));
        }

        public async Task<IActionResult> History(string? origin)
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
            if (borrower == null) return RedirectToAction(nameof(Index));

            var model = new BorrowerExtendedViewModel {
                Borrower = borrower,
                History = await _borrowerRepository.GetBorrowerHistoryAsync(selectedId.Value),
                OnLoan = await _borrowerRepository.GetItemsOnLoanAsync(borrower.BorBarNo ?? ""),
                ReturnHistory = await _borrowerRepository.GetItemReturnHistoryAsync(borrower.BorBarNo ?? "")
            };
            ViewBag.Origin = origin ?? "UsersMoreOptions";
            return View(model);
        }

        public async Task<IActionResult> Memos(string? uniqueNo, string? origin)
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
            if (borrower == null) return RedirectToAction(nameof(Index));

            var memos = await _borrowerRepository.GetBorrowerMemosAsync(selectedId.Value);
            var model = new BorrowerExtendedViewModel { Borrower = borrower, Memos = memos, MemoTypes = await _borrowerRepository.GetMemoTypesAsync() };

            if (!string.IsNullOrEmpty(uniqueNo)) model.SelectedMemo = memos.FirstOrDefault(m => m.BmUniqueNo == uniqueNo) ?? new BorMemo();
            else model.SelectedMemo = new BorMemo { BmEffDate = DateTime.Now, BmEndDate = DateTime.Now.AddYears(1), BmBorNo = selectedId.Value, BmBorBarNo = borrower.BorBarNo };

            ViewBag.Origin = origin ?? "UsersMoreOptions";
            return View(model);
        }

        [HttpPost] public async Task<IActionResult> SaveMemo(BorMemo model) { await _borrowerRepository.SaveBorrowerMemoAsync(model); return RedirectToAction(nameof(Memos)); }
        [HttpPost] public async Task<IActionResult> DeleteMemo(int borNo, string uniqueNo) { await _borrowerRepository.DeleteBorrowerMemoAsync(borNo, uniqueNo); return RedirectToAction(nameof(Memos)); }

        public async Task<IActionResult> Surveys(string? origin)
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
            var model = new BorrowerExtendedViewModel { Borrower = borrower!, AvailableSurveys = await _borrowerRepository.GetAvailableSurveysAsync() };
            ViewBag.Origin = origin ?? "UsersMoreOptions";
            return View(model);
        }

        public async Task<IActionResult> ILR(string? origin)
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
            if (borrower == null) return RedirectToAction(nameof(Index));

            var model = new BorrowerExtendedViewModel { Borrower = borrower, IlrData = await _borrowerRepository.GetBorrowerILRAsync(selectedId.Value), IlrAdditionalData = await _borrowerRepository.GetBorrowerILRAdditionalAsync(selectedId.Value) };
            ViewBag.Origin = origin ?? "UsersMoreOptions";
            return View(model);
        }

        [HttpPost] [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveILR(BorrowerExtendedViewModel model)
        {
            if (model.Borrower.BorNo == 0) return RedirectToAction(nameof(Index));
            if (model.IlrData != null) model.IlrData.BorNo = model.Borrower.BorNo;
            if (model.IlrAdditionalData != null) model.IlrAdditionalData.Borno = model.Borrower.BorNo;
            await _borrowerRepository.SaveBorrowerILRAsync(model.IlrData ?? new IlrField { BorNo = model.Borrower.BorNo }, model.IlrAdditionalData ?? new IlrAdditionalField { Borno = model.Borrower.BorNo });
            return RedirectToAction(nameof(ILR));
        }

        public IActionResult Import() => View();

        [HttpPost]
        public async Task<IActionResult> SaveAddress(BorrowerMaintenanceViewModel model)
        {
            if (model.SelectedAddress != null)
            {
                model.SelectedAddress.BaBorNo = model.Borrower.BorNo;
                var existingAddresses = await _borrowerRepository.GetBorrowerAddressesAsync(model.Borrower.BorNo);
                if (!existingAddresses.Any(a => a.BaAddressTypeId == model.SelectedAddress.BaAddressTypeId)) model.SelectedAddress.BaMain = true;
                await _borrowerRepository.SaveAddressAsync(model.SelectedAddress);
            }
            return RedirectToAction(nameof(Addresses), new { borNo = model.Borrower.BorNo });
        }

        [HttpPost] public async Task<IActionResult> DeleteAddress(int borNo, int addrNo) { await _borrowerRepository.DeleteAddressAsync(borNo, addrNo); return RedirectToAction(nameof(Addresses), new { borNo = borNo }); }

        [HttpPost]
        public async Task<IActionResult> UploadPicture(IFormFile file, int borNo)
        {
            if (file != null && file.Length > 0)
            {
                using (var ms = new System.IO.MemoryStream())
                {
                    await file.CopyToAsync(ms);
                    await _borrowerRepository.SaveBorrowerPictureAsync(new ABorPicture { BorNo = borNo, BorPicFilename = file.FileName, BorPicType = file.ContentType, BorPicData = ms.ToArray() });
                }
            }
            return RedirectToAction(nameof(UsersMoreOptions));
        }

        [HttpGet] public async Task<IActionResult> GetPicture(int borNo) { var p = await _borrowerRepository.GetBorrowerPictureAsync(borNo); return p != null ? File(p.BorPicData, p.BorPicType) : NotFound(); }
        [HttpGet] public async Task<IActionResult> GetQRCode(int borNo) { TempData["SuccessMessage"] = "QR Code interface stub."; return RedirectToAction(nameof(UsersMoreOptions)); }
        [HttpPost] public async Task<IActionResult> RemovePicture(int borNo) { await _borrowerRepository.DeleteBorrowerPictureAsync(borNo); return RedirectToAction(nameof(UsersMoreOptions)); }

        [HttpPost]
        public async Task<IActionResult> ReRegistration(int borNo, DateTime newExpiryDate)
        {
            var b = await _borrowerRepository.GetBorrowerByIdAsync(borNo);
            if (b != null) { b.BorRegdate = newExpiryDate; b.BorDatetime = DateTime.Now; await _borrowerRepository.SaveBorrowerAsync(b); }
            return RedirectToAction(nameof(UsersMoreOptions));
        }

        [HttpPost]
        public async Task<IActionResult> AmendJoiningDate(int borNo, DateTime newJoiningDate)
        {
            var b = await _borrowerRepository.GetBorrowerByIdAsync(borNo);
            if (b != null) { b.BorStartMship = newJoiningDate; b.BorDatetime = DateTime.Now; await _borrowerRepository.SaveBorrowerAsync(b); }
            return RedirectToAction(nameof(UsersMoreOptions));
        }

        public async Task<IActionResult> ViewRelatedMembers(int id)
        {
            var related = await _borrowerRepository.GetRelatedBorrowersByParentAsync(id);
            if (!related.Any()) return RedirectToAction(nameof(UsersMoreOptions));
            HttpContext.Session.SetString("NavigationIds", System.Text.Json.JsonSerializer.Serialize(related.Select(r => r.BorNo).ToList()));
            HttpContext.Session.SetString("SearchCriteria", System.Text.Json.JsonSerializer.Serialize(new BorrowerSearchCriteria()));
            return RedirectToAction(nameof(BorrowerResultTable));
        }

        public async Task<IActionResult> SendEmail(int borNo) { var b = await _borrowerRepository.GetBorrowerByIdAsync(borNo); TempData["SuccessMessage"] = $"Email stub for {b?.BorEmail}."; return RedirectToAction(nameof(UsersMoreOptions)); }

        public async Task<IActionResult> FinancialTransactions(string? origin)
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
            if (borrower == null) return RedirectToAction(nameof(Index));

            var model = new BorrowerExtendedViewModel { Borrower = borrower, FinanceTransactions = await _borrowerRepository.GetFinTransactionsAsync(borrower.BorBarNo ?? "") };
            ViewBag.Origin = origin ?? "UsersMoreOptions";
            return View(model);
        }

        public async Task<IActionResult> Courses(string? origin)
        {
            var selectedId = HttpContext.Session.GetInt32("SelectedBorrowerId");
            if (!selectedId.HasValue) return RedirectToAction(nameof(Index));
            var borrower = await _borrowerRepository.GetBorrowerByIdAsync(selectedId.Value);
            if (borrower == null) return RedirectToAction(nameof(Index));

            var model = new BorrowerExtendedViewModel { Borrower = borrower, CoursePeriods = await _borrowerRepository.GetBorrowerCoursePeriodsAsync(selectedId.Value) };
            ViewBag.Origin = origin ?? "UsersMoreOptions";
            return View(model);
        }
    }
}
