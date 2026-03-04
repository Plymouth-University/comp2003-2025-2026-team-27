using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LmsModernApp.Controllers
{
    [Authorize(AuthenticationSchemes = "StaffAuth")]
    public class StockItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
