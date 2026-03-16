using System;

namespace LmsModernApp.Models
{
    public class BorrowerSearchCriteria
    {
        public string? BorBarNo { get; set; }
        public string? BorSurname { get; set; }
        public string? BorGiven { get; set; }
        public string? BorType { get; set; }
        public string? BorGroup { get; set; }
        public string? BorClass { get; set; }
        public string? BorStatus { get; set; }
        public string? BorLocation { get; set; }
        public string? BorSex { get; set; }
        public DateTime? BorDob { get; set; }
        public string? BorDobCondition { get; set; } // "equal", "before", "after"
        
        // Paging and Sorting
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
        public string SortField { get; set; } = "BorSurname";
        public string SortOrder { get; set; } = "ASC"; // "ASC" or "DESC"
    }
}
