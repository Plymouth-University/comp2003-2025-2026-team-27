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

        public UsersController(IBorrowerRepository borrowerRepository)
        {
            _borrowerRepository = borrowerRepository;
        }

        public async Task<IActionResult> Index()
        {
            var model = new BorrowerMaintenanceViewModel();
            await PopulateLookupsAsync(model);

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
            if (ModelState.IsValid)
            {
                var success = await _borrowerRepository.SaveBorrowerAsync(model.Borrower);
                if (success)
                {
                    HttpContext.Session.SetInt32("SelectedBorrowerId", model.Borrower.BorNo);
                    TempData["SuccessMessage"] = "Borrower saved successfully.";
                    return RedirectToAction(nameof(Index));
                }
                model.Message = "Error saving borrower.";
            }

            await PopulateLookupsAsync(model);
            return View("Index", model);
        }

        public IActionResult New()
        {
            HttpContext.Session.Remove("SelectedBorrowerId");
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
                TempData["SuccessMessage"] = "Borrower deleted.";
            }
            else
            {
                TempData["ErrorMessage"] = "Error deleting borrower.";
            }
            return RedirectToAction(nameof(Index));
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

        public async Task<IActionResult> FileList(int page = 1)
        {
            var operatorName = User.Identity?.Name ?? "UNKNOWN";
            var pageSize = 8;
            
            var totalItems = await _borrowerRepository.GetFileSetsCountByOperatorAsync(operatorName);
            var fileSets = await _borrowerRepository.GetFileSetsByOperatorAsync(operatorName, page, pageSize);

            var model = new BorrowerFileListViewModel
            {
                FileSets = fileSets,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)pageSize),
                OperatorName = operatorName
            };

            var selectedId = HttpContext.Session.GetInt32("SelectedFileNumber");
            if (selectedId.HasValue)
            {
                var selectedSet = await _borrowerRepository.GetFileSetByNumberAsync(selectedId.Value);
                if (selectedSet != null)
                {
                    model.SelectedFileSet = selectedSet;
                    model.CanEdit = selectedSet.FileOper == operatorName || selectedSet.FileOperAccess == "A";
                    model.CanDelete = selectedSet.FileOper == operatorName;
                }
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult SelectFileSet(int fileNumber, int page = 1)
        {
            HttpContext.Session.SetInt32("SelectedFileNumber", fileNumber);
            return RedirectToAction(nameof(FileList), new { page });
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
