namespace LmsModernApp.ViewModels
{
    public class CatalogueEditViewModel
    {
        public int? CatNo { get; set; }

        public string? Author { get; set; }       // CatStr1
        public string? Title { get; set; }        // CatStr2
        public string? Publisher { get; set; }    // CatStr3
        public string? CallNumber { get; set; }   // CatStr4

        public string? LibGroup { get; set; } = "LIBRARY";
        public string? TemplateId { get; set; }
        public string? CatRestrict { get; set; }
        public decimal? CatSecurity { get; set; } = 0;

        public string? ReturnUrl { get; set; }

        public List<string> LibGroups { get; set; } = new() { "LIBRARY" };

        public List<string> TemplateIds { get; set; } = new()
        {
            "Book",
            "News",
            "Event",
            "Upload File",
            "Web Site - URL",
            "Discussion",
            "Catalogue Template",
            "Amend Website"
        };
    }
}
