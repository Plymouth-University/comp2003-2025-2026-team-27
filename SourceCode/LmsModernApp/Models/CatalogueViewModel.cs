using System.Collections.Generic;
using Lms.Data.Models.Decat;
namespace LmsModernApp.ViewModels
{
    public class CatalogueViewModel
    {
        // Search fields
        public string? SearchText { get; set; }
        public string? SearchMethod { get; set; } = "KW Anywhere";
        public string? LibGroup { get; set; } = "LIBRARY";
        public string? OpacViewRestriction { get; set; }
        public string? Security { get; set; } = "0";
        public string? LibraryGroup { get; set; }
        public string? TemplateId { get; set; }

        // Table results
        public List<CatalogueRowViewModel> Items { get; set; } = new();
    }

    public class CatalogueRowViewModel
    {
        public string? Tag { get; set; }
        public string? TagDescription { get; set; }
        public string? TagDetails { get; set; }
    }
}

