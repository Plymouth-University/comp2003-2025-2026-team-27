using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LmsModernApp.Controllers
{
    [Authorize(AuthenticationSchemes = "StaffAuth")]
    public class CirculationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
