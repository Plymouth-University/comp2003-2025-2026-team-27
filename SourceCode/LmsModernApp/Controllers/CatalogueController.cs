using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LmsModernApp.ViewModels;
using Lms.Data;
using Lms.Data.Models.Decat;

namespace LmsModernApp.Controllers
{
    [Authorize(AuthenticationSchemes = "StaffAuth")]
    public class CatalogueController : Controller
    {
        private readonly ICatalogueRepository _catalogueRepository;

        public CatalogueController(ICatalogueRepository catalogueRepository)
        {
            _catalogueRepository = catalogueRepository;
        }

        // ── Index / Search ────────────────────────────────────────────────────

        public IActionResult Index()
        {
            var model = new CatalogueViewModel
            {
                SearchText = string.Empty,
                SearchMethod = "Ref Number",
                LibGroup = "LIBRARY",
                OpacViewRestriction = string.Empty,
                Security = "0",
                LibraryGroup = string.Empty,
                TemplateId = string.Empty,
                Items = new List<CatalogueRowViewModel>()
            };

            return View(model);
        }

        [HttpGet, ActionName("Search")]
        public async Task<IActionResult> SearchGet(CatalogueViewModel model) => await RunSearch(model);

        [HttpPost, ActionName("Search")]
        public async Task<IActionResult> SearchPost(CatalogueViewModel model) => await RunSearch(model);

        private async Task<IActionResult> RunSearch(CatalogueViewModel model)
        {
            model.Items = new List<CatalogueRowViewModel>();

            if (!string.IsNullOrWhiteSpace(model.SearchText))
            {
                if (model.Page < 0) model.Page = 0;

                (IEnumerable<Catalogue> items, int total) result =
                    (Enumerable.Empty<Catalogue>(), 0);

                switch (model.SearchMethod)
                {
                    case "Ref Number":
                        if (int.TryParse(model.SearchText, out int catNo))
                            result = await _catalogueRepository.SearchByRefNumberAsync(
                                catNo, model.LibGroup, model.Page, CatalogueViewModel.PageSize);
                        break;

                    case "Title":
                        result = await _catalogueRepository.SearchByTitleAsync(
                            model.SearchText, model.LibGroup, model.Page, CatalogueViewModel.PageSize);
                        break;

                    case "Author":
                        result = await _catalogueRepository.SearchByAuthorAsync(
                            model.SearchText, model.LibGroup, model.Page, CatalogueViewModel.PageSize);
                        break;

                    case "Call Number":
                        result = await _catalogueRepository.SearchByCallNumberAsync(
                            model.SearchText, model.LibGroup, model.Page, CatalogueViewModel.PageSize);
                        break;
                }

                model.TotalCount = result.total;

                if (model.Page > 0 && model.Page >= model.TotalPages)
                {
                    model.Page = Math.Max(0, model.TotalPages - 1);
                    result = model.SearchMethod switch
                    {
                        "Ref Number" when int.TryParse(model.SearchText, out int cn) =>
                            await _catalogueRepository.SearchByRefNumberAsync(cn, model.LibGroup, model.Page, CatalogueViewModel.PageSize),
                        "Title" =>
                            await _catalogueRepository.SearchByTitleAsync(model.SearchText, model.LibGroup, model.Page, CatalogueViewModel.PageSize),
                        "Author" =>
                            await _catalogueRepository.SearchByAuthorAsync(model.SearchText, model.LibGroup, model.Page, CatalogueViewModel.PageSize),
                        "Call Number" =>
                            await _catalogueRepository.SearchByCallNumberAsync(model.SearchText, model.LibGroup, model.Page, CatalogueViewModel.PageSize),
                        _ => result
                    };
                }

                model.Items = result.items.Select(c => new CatalogueRowViewModel
                {
                    Tag = c.CatNo?.ToString(),
                    TagDescription = c.CatStr2,
                    TagDetails = c.CatStr1
                }).ToList();
            }

            return View("Index", model);
        }

        // ── Details ──────────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> Details(int catNo, string? libGroup, string? returnUrl)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);

            if (record == null)
                return RedirectToAction(nameof(Index));

            var model = new CatalogueDetailsViewModel
            {
                CatNo = record.CatNo,
                ReturnUrl = returnUrl,
                Author = record.CatStr1,
                Title = record.CatStr2,
                Publisher = record.CatStr3,
                CallNumber = record.CatStr4,
                LibGroup = record.CatLibGroup,
                TemplateId = record.TemplateId,
                CatRestrict = record.CatRestrict,
                CatSecurity = record.CatSecurity,
                CreatedBy = record.CatCreateOper,
                CreatedDate = record.CatCreateDatetime,
                LastModifiedBy = record.CatOper,
                LastModifiedDate = record.CatDatetime
            };

            return View(model);
        }

        // ── Duplicate ────────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> Duplicate(int catNo, string? libGroup, string? returnUrl)
        {
            var newCatNo = await _catalogueRepository.DuplicateAsync(
                catNo, libGroup, User.Identity?.Name ?? "UNKNOWN");

            return RedirectToAction(nameof(Modify), new { catNo = newCatNo, returnUrl });
        }

        // ── Add ───────────────────────────────────────────────────────────────

        [HttpGet]
        public IActionResult Add()
        {
            return View(new CatalogueEditViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(CatalogueEditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var username = User.Identity?.Name ?? "UNKNOWN";
            var now = DateTime.Now;

            var cat = new Catalogue
            {
                CatStr1 = model.Author,
                CatStr2 = model.Title,
                CatStr3 = model.Publisher,
                CatStr4 = model.CallNumber,
                CatKey1 = model.Author?.ToUpper(),
                CatKey2 = model.Title?.ToUpper(),
                CatKey3 = model.Publisher?.ToUpper(),
                CatKey4 = model.CallNumber?.ToUpper(),
                CatLibGroup = model.LibGroup,
                TemplateId = model.TemplateId,
                CatRestrict = model.CatRestrict,
                CatSecurity = model.CatSecurity,
                CatOper = username,
                CatDatetime = now,
                CatCreateOper = username,
                CatCreateDatetime = now
            };

            var newCatNo = await _catalogueRepository.AddAsync(cat);

            return RedirectToAction(nameof(Index));
        }

        // ── Modify ────────────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> Modify(int catNo, string? libGroup, string? returnUrl)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);

            if (record == null)
                return NotFound();

            var model = new CatalogueEditViewModel
            {
                CatNo = record.CatNo,
                Author = record.CatStr1,
                Title = record.CatStr2,
                Publisher = record.CatStr3,
                CallNumber = record.CatStr4,
                LibGroup = record.CatLibGroup,
                TemplateId = record.TemplateId,
                CatRestrict = record.CatRestrict,
                CatSecurity = record.CatSecurity,
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        // ── Delete ───────────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> Delete(int catNo, string? libGroup)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);

            if (record == null)
                return NotFound();

            var model = new CatalogueDeleteViewModel
            {
                CatNo = record.CatNo,
                Author = record.CatStr1,
                Title = record.CatStr2,
                Publisher = record.CatStr3,
                CallNumber = record.CatStr4,
                LibGroup = record.CatLibGroup
            };

            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int catNo)
        {
            await _catalogueRepository.DeleteAsync(catNo);
            return RedirectToAction(nameof(Index));
        }

        // ── Picture ───────────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> Picture(int catNo, string? libGroup)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);
            if (record?.CatPicData == null || string.IsNullOrEmpty(record.CatPicType))
                return NotFound();
            return File(record.CatPicData, record.CatPicType);
        }

        // ── Upload Pictures ───────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> UploadPictures(int catNo, string? libGroup, string? returnUrl)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);
            if (record == null) return NotFound();

            var model = new CatalogueUploadPictureViewModel
            {
                CatNo = record.CatNo,
                Title = record.CatStr2,
                Author = record.CatStr1,
                LibGroup = record.CatLibGroup,
                ReturnUrl = returnUrl,
                HasPicture = record.CatPicData != null,
                PicFilename = record.CatPicFilename
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UploadPictures(CatalogueUploadPictureViewModel model, IFormFile? picture)
        {
            if (picture == null || picture.Length == 0)
            {
                ModelState.AddModelError(string.Empty, "Please select a file to upload.");
                return View(model);
            }

            using var ms = new MemoryStream();
            await picture.CopyToAsync(ms);

            await _catalogueRepository.SavePictureAsync(
                model.CatNo!.Value,
                picture.FileName,
                picture.ContentType,
                ms.ToArray());

            return !string.IsNullOrEmpty(model.ReturnUrl)
                ? Redirect(model.ReturnUrl)
                : RedirectToAction(nameof(Index));
        }

        // ── Remove Picture ────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> RemovePicture(int catNo, string? libGroup, string? returnUrl)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);
            if (record == null) return NotFound();

            var model = new CatalogueUploadPictureViewModel
            {
                CatNo = record.CatNo,
                Title = record.CatStr2,
                Author = record.CatStr1,
                LibGroup = record.CatLibGroup,
                ReturnUrl = returnUrl,
                HasPicture = record.CatPicData != null,
                PicFilename = record.CatPicFilename
            };
            return View(model);
        }

        // ── Export ───────────────────────────────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> Export(int catNo, string? libGroup)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);
            if (record == null) return NotFound();

            var headers = "Ref No,Title,Author,Publisher,Call Number,Lib Group,Created By,Created Date,Modified By,Modified Date";
            var values = string.Join(",", new[]
            {
                CsvEscape(record.CatNo?.ToString()),
                CsvEscape(record.CatStr2),
                CsvEscape(record.CatStr1),
                CsvEscape(record.CatStr3),
                CsvEscape(record.CatStr4),
                CsvEscape(record.CatLibGroup),
                CsvEscape(record.CatCreateOper),
                CsvEscape(record.CatCreateDatetime?.ToString("yyyy-MM-dd HH:mm:ss")),
                CsvEscape(record.CatOper),
                CsvEscape(record.CatDatetime?.ToString("yyyy-MM-dd HH:mm:ss"))
            });

            var csv = headers + "\r\n" + values + "\r\n";
            var bytes = System.Text.Encoding.UTF8.GetBytes(csv);
            var filename = $"catalogue_{catNo}.csv";

            return File(bytes, "text/csv", filename);
        }

        private static string CsvEscape(string? value)
        {
            if (value == null) return "";
            if (value.Contains(',') || value.Contains('"') || value.Contains('\n'))
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            return value;
        }

        [HttpPost, ActionName("RemovePicture")]
        public async Task<IActionResult> RemovePictureConfirmed(int catNo, string? returnUrl)
        {
            await _catalogueRepository.RemovePictureAsync(catNo);
            return !string.IsNullOrEmpty(returnUrl)
                ? Redirect(returnUrl)
                : RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Modify(CatalogueEditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var cat = new Catalogue
            {
                CatNo = model.CatNo,
                CatStr1 = model.Author,
                CatStr2 = model.Title,
                CatStr3 = model.Publisher,
                CatStr4 = model.CallNumber,
                CatKey1 = model.Author?.ToUpper(),
                CatKey2 = model.Title?.ToUpper(),
                CatKey3 = model.Publisher?.ToUpper(),
                CatKey4 = model.CallNumber?.ToUpper(),
                CatLibGroup = model.LibGroup,
                TemplateId = model.TemplateId,
                CatRestrict = model.CatRestrict,
                CatSecurity = model.CatSecurity,
                CatOper = User.Identity?.Name ?? "UNKNOWN",
                CatDatetime = DateTime.Now
            };

            await _catalogueRepository.UpdateAsync(cat);

            return !string.IsNullOrEmpty(model.ReturnUrl)
                ? Redirect(model.ReturnUrl)
                : RedirectToAction(nameof(Index));
        }
        // ── File List (frmCatalogueFileList) ──────────────────────────────────

        [HttpGet]
        public async Task<IActionResult> FileList(int catNo, string? libGroup)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);
            if (record == null)
                return RedirectToAction(nameof(Index));

            var stockItems = await _catalogueRepository.GetStockItemsAsync(catNo);

            var model = new CatalogueFileListViewModel
            {
                CatNo = catNo,
                Title = record.CatStr2,
                Author = record.CatStr1,
                LibGroup = record.CatLibGroup,
                StockItems = stockItems.Select(s => new CatalogueStockItemRow
                {
                    StkItemNo = s.StkItemNo,
                    StkLine1 = s.StkLine1,
                    StkLine2 = s.StkLine2,
                    StkLocPerm = s.StkLocPerm,
                    StkLocTemp = s.StkLocTemp,
                    StkForLoan = s.StkForLoan,
                    StkIsOnLoan = s.StkIsOnLoan,
                    StkEdition = s.StkEdition,
                    StkVolume = s.StkVolume,
                    StkCost = s.StkCost,
                    StkDateRecd = s.StkDateRecd,
                    StkLibGroup = s.StkLibGroup,
                    StkOper = s.StkOper,
                    StkDatetime = s.StkDatetime
                }).ToList()
            };

            return View(model);
        }

        // ── Book Create (frmCatalogueBookCreate) ──────────────────────────────

        [HttpGet]
        public async Task<IActionResult> BookCreate(int catNo, string? libGroup, string? returnUrl)
        {
            var record = await _catalogueRepository.GetByRefNumberAsync(catNo, libGroup);
            if (record == null)
                return RedirectToAction(nameof(Index));

            var model = new CatalogueBookCreateViewModel
            {
                CatNo = catNo,
                Title = record.CatStr2,
                Author = record.CatStr1,
                LibGroup = record.CatLibGroup,
                StkDateRecd = DateTime.Today
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BookCreate(CatalogueBookCreateViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var username = User.Identity?.Name ?? "UNKNOWN";
            var now = DateTime.Now;

            var item = new StockItemDto
            {
                StkCatRef = model.CatNo,
                StkItemNo = model.StkItemNo,
                StkLine1 = model.StkLine1,
                StkLine2 = model.StkLine2,
                StkLine3 = model.StkLine3,
                StkLine4 = model.StkLine4,
                StkEdition = model.StkEdition,
                StkVolume = model.StkVolume,
                StkCost = model.StkCost,
                StkLocPerm = model.StkLocPerm,
                StkLocTemp = model.StkLocTemp,
                StkForLoan = model.StkForLoan,
                StkStatsCode = model.StkStatsCode,
                StkDescription = model.StkDescription,
                StkLibGroup = model.LibGroup,
                StkDateRecd = model.StkDateRecd ?? DateTime.Today,
                StkOper = username,
                StkDatetime = now
            };

            await _catalogueRepository.AddStockItemAsync(item);

            TempData["SuccessMessage"] = $"Stock item '{model.StkItemNo}' added successfully.";

            return RedirectToAction(nameof(FileList), new { catNo = model.CatNo, libGroup = model.LibGroup });
        }

        // ── Delete Stock Item ─────────────────────────────────────────────────

        [HttpPost]
        public async Task<IActionResult> DeleteStockItem(string stkItemNo, int catNo, string? libGroup)
        {
            await _catalogueRepository.DeleteStockItemAsync(stkItemNo);
            TempData["SuccessMessage"] = $"Stock item '{stkItemNo}' deleted.";
            return RedirectToAction(nameof(FileList), new { catNo, libGroup });
        }
    }
}
