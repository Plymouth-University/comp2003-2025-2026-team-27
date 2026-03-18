using System.Collections.Generic;

namespace LmsModernApp.ViewModels
{
    public class CatalogueViewModel
    {
        // Search fields
        public string? SearchText { get; set; }
        public string? SearchMethod { get; set; } = "Ref Number";
        public string? LibGroup { get; set; } = "LIBRARY";
        public string? OpacViewRestriction { get; set; }
        public string? Security { get; set; } = "0";
        public string? LibraryGroup { get; set; }
        public string? TemplateId { get; set; }

        // Available search methods for dropdown
        public List<string> SearchMethods { get; set; } = new()
        {
            "Ref Number",
            "Title",
            "Author",
            "Call Number"
        };

        // Available lib groups for dropdown
        public List<string> LibGroups { get; set; } = new()
        {
            "LIBRARY"
        };

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