using Lms.Data.Models.Decat;

namespace Lms.Data
{
    public interface ICatalogueRepository
    {
        Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByRefNumberAsync(int catNo, string? libGroup, int page, int pageSize);
        Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByTitleAsync(string title, string? libGroup, int page, int pageSize);
        Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByAuthorAsync(string author, string? libGroup, int page, int pageSize);
        Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByCallNumberAsync(string callNumber, string? libGroup, int page, int pageSize);

        Task<Catalogue?> GetByRefNumberAsync(int catNo, string? libGroup);
        Task<int> AddAsync(Catalogue catalogue);
        Task<int> DuplicateAsync(int catNo, string? libGroup, string? operName);
        Task UpdateAsync(Catalogue catalogue);
        Task DeleteAsync(int catNo);
        Task SavePictureAsync(int catNo, string filename, string mimeType, byte[] data);
        Task RemovePictureAsync(int catNo);

        // ── Stock Items ───────────────────────────────────────────────────────
        Task<IEnumerable<StockItemDto>> GetStockItemsAsync(int catNo);
        Task AddStockItemAsync(StockItemDto item);
        Task DeleteStockItemAsync(string stkItemNo);
    }

    public class StockItemDto
    {
        public int? StkCatRef { get; set; }
        public string? StkItemNo { get; set; }
        public string? StkLine1 { get; set; }
        public string? StkLine2 { get; set; }
        public string? StkLine3 { get; set; }
        public string? StkLine4 { get; set; }
        public string? StkEdition { get; set; }
        public string? StkVolume { get; set; }
        public decimal? StkCost { get; set; }
        public string? StkLocPerm { get; set; }
        public string? StkLocTemp { get; set; }
        public string? StkForLoan { get; set; }
        public string? StkIsOnLoan { get; set; }
        public string? StkStatsCode { get; set; }
        public string? StkDescription { get; set; }
        public string? StkLibGroup { get; set; }
        public DateTime? StkDateRecd { get; set; }
        public string? StkOper { get; set; }
        public DateTime? StkDatetime { get; set; }
    }
}
