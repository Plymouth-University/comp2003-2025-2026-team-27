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

        public IActionResult FileList()
        {
            return View();
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
