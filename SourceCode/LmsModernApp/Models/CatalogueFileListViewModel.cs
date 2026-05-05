namespace LmsModernApp.ViewModels
{
    public class CatalogueFileListViewModel
    {
        public int CatNo { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? LibGroup { get; set; }
        public string? ReturnUrl { get; set; }

        public List<CatalogueStockItemRow> StockItems { get; set; } = new();
    }

    public class CatalogueStockItemRow
    {
        public string? StkItemNo { get; set; }
        public string? StkLine1 { get; set; }      // Location / branch
        public string? StkLine2 { get; set; }      // Condition / notes
        public string? StkLocPerm { get; set; }    // Permanent location
        public string? StkLocTemp { get; set; }    // Temporary location
        public string? StkForLoan { get; set; }    // Available for loan?
        public string? StkIsOnLoan { get; set; }   // Currently on loan?
        public string? StkEdition { get; set; }
        public string? StkVolume { get; set; }
        public decimal? StkCost { get; set; }
        public DateTime? StkDateRecd { get; set; }
        public string? StkLibGroup { get; set; }
        public string? StkOper { get; set; }
        public DateTime? StkDatetime { get; set; }
    }
}
