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
        //Returns the number of issues goruped by borrower group with date range
        Task<List<IssuesByBorrowerGroupDto>> GetIssuesByBorrowerGroupAsync(DateTime fromDate, DateTime toDate);
        
        //Returns the total number of borrowers
        Task<int> GetTotalMemberCountAsync();

        //Returns the total number of unique books that have been loaned
        Task<int> GetTotalBookCountAsync();

        //Returns the minimum and maximum issue dates in the system
        Task<(DateTime MinDate, DateTime MaxDate)> GetIssueDateRangeAsync();

    }
    public class IssuesByBorrowerGroupDto
    {
        public string GroupName { get; set; } = "";
        public int IssueCount { get; set; }
    }
}
