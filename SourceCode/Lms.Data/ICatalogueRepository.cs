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
    }
}
