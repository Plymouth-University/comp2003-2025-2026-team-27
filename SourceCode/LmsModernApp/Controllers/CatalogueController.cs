using Lms.Data;
using Lms.Data.Models.Decat;
using LmsModernApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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

        // ?? Index / Search ????????????????????????????????????????????????????

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

        [HttpPost]
        public async Task<IActionResult> Search(CatalogueViewModel model)
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

        // ?? Add ???????????????????????????????????????????????????????????????

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

        // ?? Modify ????????????????????????????????????????????????????????????

        [HttpGet]
        public async Task<IActionResult> Modify(int catNo, string? libGroup)
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
                CatSecurity = record.CatSecurity
            };

            return View(model);
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

            return RedirectToAction(nameof(Index));
        }
    }
}