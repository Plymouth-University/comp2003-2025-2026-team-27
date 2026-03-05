using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using LmsModernApp.ViewModels;

namespace LmsModernApp.Controllers
{
    [Authorize(AuthenticationSchemes = "StaffAuth")]
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            var model = new CatalogueViewModel
            {
                SearchText = string.Empty,
                SearchMethod = "KW Anywhere",
                LibGroup = "LIBRARY",
                OpacViewRestriction = string.Empty,
                Security = "0",
                LibraryGroup = string.Empty,
                TemplateId = string.Empty,
                Items = new List<CatalogueRowViewModel>()
            };

            return View(model);
        }
    }
}