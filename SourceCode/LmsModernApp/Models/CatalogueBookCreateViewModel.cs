using System.ComponentModel.DataAnnotations;

namespace LmsModernApp.ViewModels
{
    public class CatalogueBookCreateViewModel
    {
        public int CatNo { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? LibGroup { get; set; }

        [Required(ErrorMessage = "Item number is required")]
        public string? StkItemNo { get; set; }

        public string? StkLine1 { get; set; }       // Location / branch
        public string? StkLine2 { get; set; }       // Condition / notes
        public string? StkLine3 { get; set; }
        public string? StkLine4 { get; set; }

        public string? StkEdition { get; set; }
        public string? StkVolume { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Cost must be a positive number")]
        public decimal? StkCost { get; set; }

        public string? StkLocPerm { get; set; }     // Permanent location
        public string? StkLocTemp { get; set; }     // Temporary location
        public string? StkForLoan { get; set; } = "Y";
        public string? StkStatsCode { get; set; }
        public string? StkDescription { get; set; }

        public DateTime? StkDateRecd { get; set; } = DateTime.Today;

        public List<string> ForLoanOptions { get; set; } = new() { "Y", "N" };
    }
}
