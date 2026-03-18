using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LmsModernApp.ViewModels;
using Lms.Data;

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
                // Ref Number search — CAT_NO must be a valid integer
                if (model.SearchMethod == "Ref Number" && int.TryParse(model.SearchText, out int catNo))
                {
                    var results = await _catalogueRepository.SearchByRefNumberAsync(catNo, model.LibGroup);

                    model.Items = results.Select(c => new CatalogueRowViewModel
                    {
                        Tag = c.CatNo?.ToString(),
                        TagDescription = c.CatStr2,  // Title
                        TagDetails = c.CatStr1    // Author
                    }).ToList();
                }
            }

            return View("Index", model);
        }
    }
}