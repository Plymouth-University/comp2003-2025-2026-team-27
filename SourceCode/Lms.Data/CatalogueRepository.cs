using Lms.Data.Models.Decat;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data
{
    public class CatalogueRepository : ICatalogueRepository
    {
        private readonly DecatContext _context;

        public CatalogueRepository(DecatContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Catalogue>> SearchByRefNumberAsync(int catNo, string? libGroup)
        {
            var query = _context.Catalogues.AsQueryable();

            // Filter by CAT_NO
            query = query.Where(c => c.CatNo == catNo);

            // Optionally filter by library group if provided
            if (!string.IsNullOrWhiteSpace(libGroup))
            {
                query = query.Where(c => c.CatLibGroup == libGroup);
            }

            return await query.ToListAsync();
        }
    }
}