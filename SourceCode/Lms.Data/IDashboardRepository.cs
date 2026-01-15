using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data
{
    public interface IDashboardRepository
    {
        Task<List<IssuesByBorrowerGroupDto>> GetIssuesByBorrowerGroupAsync(DateTime fromDate, DateTime toDate);
        Task<int> GetTotalMemberCountAsync();
        Task<int> GetTotalBookCountAsync();

        Task<(DateTime MinDate, DateTime MaxDate)> GetIssueDateRangeAsync();

    }
    public class IssuesByBorrowerGroupDto
    {
        public string GroupName { get; set; } = "";
        public int IssueCount { get; set; }
    }
}
