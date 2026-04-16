using Lms.Data;
using LmsModernApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LmsModernApp.Controllers
{
    [Authorize(AuthenticationSchemes = "StaffAuth")]
    public class DashboardController : Controller
    {
        private readonly IDashboardRepository _repo;
        private readonly IBorrowerRepository _borRepo;
        private readonly IOperatorRepository _operRepo;

        public DashboardController(IDashboardRepository repo, IBorrowerRepository borRepo, IOperatorRepository operRepo)
        {
            _repo = repo;
            _borRepo = borRepo;
            _operRepo = operRepo;
        }

        public async Task<IActionResult> Index(DateTime? from, DateTime? to)
        {
            // Default range: last month to today
            var fromDate = from ?? DateTime.Today.AddMonths(-1);
            var toDate = to ?? DateTime.Today;

            if (fromDate > toDate)
            {
                var tmp = fromDate;
                fromDate = toDate;
                toDate = tmp;
            }

            var totalMembers = await _repo.GetTotalMemberCountAsync();
            var totalBooks = await _repo.GetTotalBookCountAsync();
            
            // Initial data for charts
            var distribution = await _repo.GetIssuesByDistributionAsync("Class", fromDate, toDate);
            var trends = await _repo.GetHistoricalTrendsAsync("Loan", fromDate, toDate);

            var vm = new DashboardViewModel
            {
                TotalMemberCount = totalMembers,
                TotalBookCount = totalBooks,
                FromDate = fromDate,
                ToDate = toDate,
                Labels = distribution.Select(x => x.Label).ToList(),
                Values = distribution.Select(x => x.Count).ToList(),
                Percentages = distribution.Select(x => x.Percentage).ToList(),
                Trends = trends,
                UserFiles = await _borRepo.GetWritableFileSetsAsync(User.Identity?.Name ?? "Admin"),
                Operators = await _operRepo.GetAllOperatorsAsync()
            };

            return View(vm);
        }

        [HttpGet]
        public async Task<JsonResult> GetChartData(string filter, string groupBy, DateTime from, DateTime to, bool overdueOnly, int? fileNumber, string? operatorName)
        {
            List<DashboardDistributionDto> distribution;
            if (filter == "Loan")
            {
                if (groupBy == "CatalogueSubject")
                {
                    distribution = await _repo.GetCatalogueSubjectsAsync(fileNumber, operatorName, overdueOnly);
                }
                else
                {
                    distribution = await _repo.GetIssuesByDistributionAsync(groupBy, from, to, overdueOnly, fileNumber, operatorName);
                }
            }
            else
            {
                distribution = await _repo.GetBorrowerDistributionAsync(groupBy, fileNumber, operatorName);
            }

            var trends = await _repo.GetHistoricalTrendsAsync(filter, from, to, fileNumber, operatorName);

            return Json(new { 
                labels = distribution.Select(x => x.Label), 
                values = distribution.Select(x => x.Count),
                percentages = distribution.Select(x => x.Percentage),
                trends = trends.Select(t => new {
                    label = t.Label,
                    dates = t.Points.Select(p => p.Date.ToString("yyyy-MM-dd")),
                    counts = t.Points.Select(p => p.Count)
                })
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetDrillDown(string groupBy, string groupValue, string filter, bool overdueOnly, int? fileNumber, string? operatorName, int page = 1)
        {
            var pagedResult = await _repo.GetBorrowerDrillDownAsync(groupBy, groupValue, filter, overdueOnly, fileNumber, operatorName, page, 10);
            return PartialView("_DrillDownResults", pagedResult);
        }
    }
}
