using Lms.Data;
using System.Collections.Generic;

namespace LmsModernApp.Models
{
    public class BorrowerMaintenanceViewModel
    {
        // Fully qualified to avoid collision with LmsModernApp.Models.Borrower
        public Lms.Data.Models.Delib.Borrower Borrower { get; set; } = new Lms.Data.Models.Delib.Borrower();

        public List<LookupItem> BorrowerTypes { get; set; } = new();
        public List<LookupItem> BorrowerGroups { get; set; } = new();
        public List<LookupItem> BorrowerClasses { get; set; } = new();
        public List<LookupItem> BorrowerStatuses { get; set; } = new();
        public List<LookupItem> Locations { get; set; } = new();
        public List<LookupItem> Titles { get; set; } = new();
        public List<LookupItem> Areas { get; set; } = new();
        public List<LookupItem> Wards { get; set; } = new();

        public string? Message { get; set; }
        public bool IsSuccess { get; set; }
    }
}
