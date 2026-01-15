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
            var (minDate, maxDate) = await _repo.GetIssueDateRangeAsync();

            var fromDate = from ?? minDate;
            var toDate = to ?? maxDate;

            if (fromDate > toDate)
            {
                var tmp = fromDate;
                fromDate = toDate;
                toDate = tmp;
            }

            var totalMembers = await _repo.GetTotalMemberCountAsync();
            var totalBooks = await _repo.GetTotalBookCountAsync();
            var grouped = await _repo.GetIssuesByBorrowerGroupAsync(fromDate, toDate);

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