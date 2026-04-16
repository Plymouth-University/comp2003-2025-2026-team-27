using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data
{
    //For data access operations used by the dashboard.
    public interface IDashboardRepository
    {
        // Returns the number of issues grouped by a dynamic category (Class, Group, Type)
        Task<List<DashboardDistributionDto>> GetIssuesByDistributionAsync(string groupBy, DateTime fromDate, DateTime toDate, bool overdueOnly = false, int? fileNumber = null, string? operatorName = null);
        
        // Returns the number of issues grouped by Catalogue Subject
        Task<List<DashboardDistributionDto>> GetCatalogueSubjectsAsync(int? fileNumber = null, string? operatorName = null, bool overdueOnly = false);
        
        //Returns counts for a specific borrower category
        Task<List<DashboardDistributionDto>> GetBorrowerDistributionAsync(string groupBy, int? fileNumber = null, string? operatorName = null);

        //Returns historical trends (daily counts) for the line chart
        Task<List<TrendDto>> GetHistoricalTrendsAsync(string trendType, DateTime fromDate, DateTime toDate, int? fileNumber = null, string? operatorName = null);

        //Returns a list of borrowers for a specific segment (drill-down) with pagination
        Task<PagedResult<BorrowerDrillDownDto>> GetBorrowerDrillDownAsync(string groupBy, string groupValue, string filterType, bool overdueOnly = false, int? fileNumber = null, string? operatorName = null, int page = 1, int pageSize = 10);

        //Returns the total number of borrowers
        Task<int> GetTotalMemberCountAsync();

        //Returns the total number of unique books that have been loaned
        Task<int> GetTotalBookCountAsync();

        //Returns the minimum and maximum issue dates in the system
        Task<(DateTime MinDate, DateTime MaxDate)> GetIssueDateRangeAsync();
    }

    public class DashboardDistributionDto
    {
        public string Label { get; set; } = "";
        public int Count { get; set; }
        public double Percentage { get; set; }
    }

    public class TrendDto
    {
        public string Label { get; set; } = ""; // The Group Name
        public List<TrendPoint> Points { get; set; } = new();
    }

    public class TrendPoint
    {
        public DateTime Date { get; set; }
        public int Count { get; set; }
    }

    public class BorrowerDrillDownDto
    {
        public int BorNo { get; set; }
        public string? Barcode { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Group { get; set; }
        public string? Class { get; set; }
        public int LoanCount { get; set; }
    }

    public class IssuesByBorrowerGroupDto
    {
        public string GroupName { get; set; } = "";
        public int IssueCount { get; set; }
    }
}
