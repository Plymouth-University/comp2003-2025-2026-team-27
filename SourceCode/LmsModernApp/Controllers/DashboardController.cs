using Lms.Data;
using LmsModernApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LmsModernApp.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardController(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new DashboardViewModel
            {
                TotalBookCount = await _dashboardRepository.GetTotalBookCountAsync(),
                TotalMemberCount = await _dashboardRepository.GetTotalMemberCountAsync()
            };

            return View(viewModel);
        }
    }
}
