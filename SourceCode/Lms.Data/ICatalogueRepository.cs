using Lms.Data.Models.Decat;

namespace Lms.Data
{
    public interface ICatalogueRepository
    {
        /// <summary>
        /// Search catalogue records by CAT_NO, optionally filtered by library group.
        /// </summary>
        Task<IEnumerable<Catalogue>> SearchByRefNumberAsync(int catNo, string? libGroup);
    }
}