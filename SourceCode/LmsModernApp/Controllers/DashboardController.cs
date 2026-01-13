using Lms.Data;
using LmsModernApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LmsModernApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _repo;

        public DashboardController(IDashboardRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index(DateTime? from, DateTime? to)
        {
            var toDate = (to ?? DateTime.Today).Date;
            var fromDate = (from ?? DateTime.Today.AddDays(-30)).Date;

            if (fromDate > toDate)
            {
                var tmp = fromDate;
                fromDate = toDate;
                toDate = tmp;
            }

            var totalsMembers = await _repo.GetTotalMemberCountAsync();
            var totalsBooks = await _repo.GetTotalBookCountAsync();

            var grouped = await _repo.GetIssuesByBorrowerGroupAsync(fromDate, toDate);

            var vm = new DashboardViewModel
            {
                TotalMemberCount = totalsMembers,
                TotalBookCount = totalsBooks,
                FromDate = fromDate,
                ToDate = toDate,
                Labels = grouped.Select(x => x.GroupName).ToList(),
                Values = grouped.Select(x => x.IssueCount).ToList()
            };

            return View(vm);
        }
    }
}