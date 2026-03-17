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
        Task<PagedResult<FileSetName>> GetFileSetsByCreatorAsync(
            string creatorName, 
            int page, 
            int pageSize, 
            string sortBy = "FileDesc", 
            string sortOrder = "ASC",
            string? searchTerm = null);
        Task<int> GetFileSetsCountByOperatorAsync(string operatorName);
        Task<FileSetName?> GetFileSetByNumberAsync(int fileNumber);
        Task<bool> SaveFileSetNameAsync(FileSetName fileSet);
        Task<bool> DeleteFileSetAsync(int fileNumber);
        Task<bool> EmptyFileSetAsync(int fileNumber);

        // Catalog Reading Lists (General Catalog Files)
        Task<List<Lms.Data.Models.Decat.FileCatName>> GetGeneralCatalogFilesAsync();
        Task<List<AFileSetLibCat>> GetRelatedReadingListsAsync(int borrowerFileNumber);
        Task<bool> SaveRelatedReadingListsAsync(int borrowerFileNumber, List<AFileSetLibCat> links);

        // Search
        Task<PagedResult<BorrowerWithAddress>> SearchBorrowersAsync(
            string? barcode, 
            string? surname, 
            string? givenName,
            string? type,
            string? group,
            string? className,
            string? status,
            string? location,
            string? sex,
            DateTime? dob,
            string? dobCondition,
            int? fileNumber,
            List<string> allowedGroups,
            int page,
            int pageSize,
            string sortField,
            string sortOrder);

        Task<BorAddr?> GetMainAddressAsync(int borNo);
    }

    public class LookupItem
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
