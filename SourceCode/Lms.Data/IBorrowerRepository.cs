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

        // File Set (Borrower List) Management
        Task<List<FileSetName>> GetFileSetsByOperatorAsync(string operatorName, int page, int pageSize);
        Task<int> GetFileSetsCountByOperatorAsync(string operatorName);
        Task<FileSetName?> GetFileSetByNumberAsync(int fileNumber);
        Task<bool> SaveFileSetNameAsync(FileSetName fileSet);
        Task<bool> DeleteFileSetAsync(int fileNumber);
        Task<bool> EmptyFileSetAsync(int fileNumber);
    }

    public class LookupItem
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
