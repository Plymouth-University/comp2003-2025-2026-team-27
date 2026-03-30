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
        public List<Lms.Data.Models.Delocal.Suburb> Suburbs { get; set; } = new();
        public List<Lms.Data.Models.Delib.ABorAddressType> AddressTypes { get; set; } = new();

        public string? Message { get; set; }
        public bool IsSuccess { get; set; }

        public string? CorrespondenceAddress { get; set; }
        public string? ResidentialAddress { get; set; }
        public string? GuardianAddress { get; set; }

        public List<Lms.Data.Models.Delib.BorAddr> Addresses { get; set; } = new();
        public Lms.Data.Models.Delib.BorAddr SelectedAddress { get; set; } = new();
    }
}
