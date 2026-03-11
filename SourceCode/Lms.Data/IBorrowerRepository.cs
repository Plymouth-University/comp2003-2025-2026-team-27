using Lms.Data.Models.Delib;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lms.Data
{
    public interface IBorrowerRepository
    {
        Task<Borrower?> GetBorrowerByIdAsync(int id);
        Task<Borrower?> GetBorrowerByBarcodeAsync(string barcode);
        Task<bool> SaveBorrowerAsync(Borrower borrower);
        Task<bool> DeleteBorrowerAsync(int id);
        Task<List<LookupItem>> GetBorrowerTypesAsync();
        Task<List<LookupItem>> GetBorrowerGroupsAsync();
        Task<List<LookupItem>> GetBorrowerClassesAsync();
        Task<List<LookupItem>> GetBorrowerStatusesAsync();
        Task<List<LookupItem>> GetLocationsAsync();
        Task<List<LookupItem>> GetTitlesAsync();
        Task<List<LookupItem>> GetAreasAsync();
        Task<List<LookupItem>> GetWardsAsync();
    }

    public class LookupItem
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
