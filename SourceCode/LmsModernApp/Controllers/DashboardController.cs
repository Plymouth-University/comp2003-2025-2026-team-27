using Lms.Data;
using LmsModernApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LmsModernApp.Controllers
{
    //Handles dashboard page requests and preps data
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _repo;

        public DashboardController(IDashboardRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index(DateTime? from, DateTime? to)
        {
            //Defaults to full range for issue daates if no range is provided
            var (minDate, maxDate) = await _repo.GetIssueDateRangeAsync();

            var fromDate = from ?? minDate;
            var toDate = to ?? maxDate;

            //Swaps if user inputs dates in wrong oder
            if (fromDate > toDate)
            {
                var tmp = fromDate;
                fromDate = toDate;
                toDate = tmp;
            }

            var totalMembers = await _repo.GetTotalMemberCountAsync();
            var totalBooks = await _repo.GetTotalBookCountAsync();
            var grouped = await _repo.GetIssuesByBorrowerGroupAsync(fromDate, toDate);

            //Builds view model for dashboard UI and charts
            var vm = new DashboardViewModel
            {
                TotalMemberCount = totalMembers,
                TotalBookCount = totalBooks,
                FromDate = fromDate,
                ToDate = toDate,
                Labels = grouped.Select(x => x.GroupName).ToList(),
                Values = grouped.Select(x => x.IssueCount).ToList()
            };

            return View(vm);
        }
    }
}