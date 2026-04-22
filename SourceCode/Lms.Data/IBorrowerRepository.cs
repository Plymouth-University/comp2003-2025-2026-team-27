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
        Task<List<FileSetName>> GetWritableFileSetsAsync(string operatorName);
        Task<int> AddBorrowersToFileAsync(int fileNumber, List<int> borNos);
        Task<int> RemoveBorrowersFromFileAsync(int fileNumber, List<int> borNos);

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
        Task<List<BorAddr>> GetBorrowerAddressesAsync(int borNo);
        Task<List<ABorAddressType>> GetAddressTypesAsync();
        Task<List<Lms.Data.Models.Delocal.Suburb>> GetSuburbsAsync();
        Task<bool> SaveAddressAsync(BorAddr address);
        Task<bool> DeleteAddressAsync(int borNo, int addrNo);

        // Extended Management Actions
        Task<bool> ApproveRegistrationAsync(int borNo);
        Task<bool> RejectRegistrationAsync(int borNo);
        Task<bool> ResetPinAsync(string barcode);
        Task<bool> SetRelationshipAsync(int borNo, int? parentBorNo, string relType);
        Task<bool> SetGroupRelationshipAsync(int borNo, int? groupParentBorNo);
        Task<List<Borrower>> GetRelatedBorrowersAsync(int borNo);
        Task<List<Borrower>> GetRelatedGroupBorrowersAsync(int borNo);

        // History, Memos, Surveys, and ILR
        Task<List<BorHistory>> GetBorrowerHistoryAsync(int borNo);
        Task<List<StkItem>> GetItemsOnLoanAsync(string barcode);
        Task<List<StkHistory>> GetItemReturnHistoryAsync(string barcode);
        Task<List<BorMemo>> GetBorrowerMemosAsync(int borNo);
        Task<int> GetMemoCountAsync(int borNo);
        Task<bool> SaveBorrowerMemoAsync(BorMemo memo);
        Task<bool> DeleteBorrowerMemoAsync(int borNo, string uniqueNo);
        Task<List<LookupItem>> GetMemoTypesAsync();
        Task<List<Survey>> GetAvailableSurveysAsync();
        Task<BorSurvey?> GetBorrowerSurveyAsync(int borNo, int surveyId);
        Task<Lms.Data.Models.Delib.IlrField?> GetBorrowerILRAsync(int borNo);
        Task<Lms.Data.Models.Delib.IlrAdditionalField?> GetBorrowerILRAdditionalAsync(int borNo);
        Task<bool> SaveBorrowerILRAsync(IlrField field, IlrAdditionalField additional);

        // Picture Management
        Task<ABorPicture?> GetBorrowerPictureAsync(int borNo);
        Task<bool> SaveBorrowerPictureAsync(ABorPicture picture);
        Task<bool> DeleteBorrowerPictureAsync(int borNo);

        // Course Management
        Task<List<BorCoursePeriod>> GetBorrowerCoursePeriodsAsync(int borNo);
        Task<bool> SaveBorCoursePeriodAsync(BorCoursePeriod period);
        Task<bool> DeleteBorCoursePeriodAsync(int borNo, string coCode, DateTime from, DateTime to);

        // Relationships
        Task<List<Borrower>> GetRelatedBorrowersByParentAsync(int parentBorNo);

        // Finance
        Task<List<FinTran>> GetFinTransactionsAsync(string barcode);
    }

    public class LookupItem
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
