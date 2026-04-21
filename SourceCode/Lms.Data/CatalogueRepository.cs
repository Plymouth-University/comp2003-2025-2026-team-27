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

        // ── Search ────────────────────────────────────────────────────────────

        public async Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByRefNumberAsync(
            int catNo, string? libGroup, int page, int pageSize)
        {
            var query = _context.Catalogues.AsQueryable()
                .Where(c => c.CatNo == catNo);

            if (!string.IsNullOrWhiteSpace(libGroup))
                query = query.Where(c => c.CatLibGroup == libGroup);

            var total = await query.CountAsync();
            var items = await query.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return (items, total);
        }

        public async Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByTitleAsync(
            string title, string? libGroup, int page, int pageSize)
        {
            var pattern = "%" + title.ToUpper() + "%";
            var query = _context.Catalogues.AsQueryable()
                .Where(c => EF.Functions.Like(c.CatKey2, pattern));

            if (!string.IsNullOrWhiteSpace(libGroup))
                query = query.Where(c => c.CatLibGroup == libGroup);

            var total = await query.CountAsync();
            var items = await query.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return (items, total);
        }

        public async Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByAuthorAsync(
            string author, string? libGroup, int page, int pageSize)
        {
            var pattern = "%" + author.ToUpper() + "%";
            var query = _context.Catalogues.AsQueryable()
                .Where(c => EF.Functions.Like(c.CatKey1, pattern));

            if (!string.IsNullOrWhiteSpace(libGroup))
                query = query.Where(c => c.CatLibGroup == libGroup);

            var total = await query.CountAsync();
            var items = await query.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return (items, total);
        }

        public async Task<(IEnumerable<Catalogue> Items, int TotalCount)> SearchByCallNumberAsync(
            string callNumber, string? libGroup, int page, int pageSize)
        {
            var pattern = "%" + callNumber.ToUpper() + "%";
            var query = _context.Catalogues.AsQueryable()
                .Where(c => EF.Functions.Like(c.CatKey4, pattern));

            if (!string.IsNullOrWhiteSpace(libGroup))
                query = query.Where(c => c.CatLibGroup == libGroup);

            var total = await query.CountAsync();
            var items = await query.Skip(page * pageSize).Take(pageSize).ToListAsync();
            return (items, total);
        }

        // ── Single record ─────────────────────────────────────────────────────

        public async Task<Catalogue?> GetByRefNumberAsync(int catNo, string? libGroup)
        {
            var query = _context.Catalogues.AsQueryable()
                .Where(c => c.CatNo == catNo);

            if (!string.IsNullOrWhiteSpace(libGroup))
                query = query.Where(c => c.CatLibGroup == libGroup);

            return await query.FirstOrDefaultAsync();
        }

        // ── Write ─────────────────────────────────────────────────────────────

        public async Task<int> DuplicateAsync(int catNo, string? libGroup, string? operName)
        {
            var original = await GetByRefNumberAsync(catNo, libGroup)
                ?? throw new InvalidOperationException($"Catalogue record {catNo} not found.");

            var nextNo = (await _context.Catalogues
                .Where(c => c.CatNo != null)
                .MaxAsync(c => (int?)c.CatNo) ?? 0) + 1;

            var now = DateTime.Now;

            await _context.Database.ExecuteSqlInterpolatedAsync($@"
                INSERT INTO CATALOGUE
                    (CAT_NO, CAT_STR1, CAT_STR2, CAT_STR3, CAT_STR4,
                     CAT_KEY1, CAT_KEY2, CAT_KEY3, CAT_KEY4,
                     CAT_LIB_GROUP, TEMPLATE_ID,
                     CAT_RESTRICT, CAT_SECURITY,
                     CAT_OPER, CAT_DATETIME,
                     CAT_CREATE_OPER, CAT_CREATE_DATETIME)
                VALUES
                    ({nextNo}, {original.CatStr1}, {original.CatStr2}, {original.CatStr3}, {original.CatStr4},
                     {original.CatKey1}, {original.CatKey2}, {original.CatKey3}, {original.CatKey4},
                     {original.CatLibGroup}, {original.TemplateId},
                     {original.CatRestrict}, {original.CatSecurity},
                     {operName}, {now},
                     {operName}, {now})");

            return nextNo;
        }

        public async Task<int> AddAsync(Catalogue cat)
        {
            var nextNo = (await _context.Catalogues
                .Where(c => c.CatNo != null)
                .MaxAsync(c => (int?)c.CatNo) ?? 0) + 1;

            cat.CatNo = nextNo;

            await _context.Database.ExecuteSqlInterpolatedAsync($@"
                INSERT INTO CATALOGUE
                    (CAT_NO, CAT_STR1, CAT_STR2, CAT_STR3, CAT_STR4,
                     CAT_KEY1, CAT_KEY2, CAT_KEY3, CAT_KEY4,
                     CAT_LIB_GROUP, TEMPLATE_ID,
                     CAT_RESTRICT, CAT_SECURITY,
                     CAT_OPER, CAT_DATETIME,
                     CAT_CREATE_OPER, CAT_CREATE_DATETIME)
                VALUES
                    ({cat.CatNo}, {cat.CatStr1}, {cat.CatStr2}, {cat.CatStr3}, {cat.CatStr4},
                     {cat.CatKey1}, {cat.CatKey2}, {cat.CatKey3}, {cat.CatKey4},
                     {cat.CatLibGroup}, {cat.TemplateId},
                     {cat.CatRestrict}, {cat.CatSecurity},
                     {cat.CatOper}, {cat.CatDatetime},
                     {cat.CatCreateOper}, {cat.CatCreateDatetime})");

            return nextNo;
        }

        public async Task UpdateAsync(Catalogue cat)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($@"
                UPDATE CATALOGUE SET
                    CAT_STR1            = {cat.CatStr1},
                    CAT_STR2            = {cat.CatStr2},
                    CAT_STR3            = {cat.CatStr3},
                    CAT_STR4            = {cat.CatStr4},
                    CAT_KEY1            = {cat.CatKey1},
                    CAT_KEY2            = {cat.CatKey2},
                    CAT_KEY3            = {cat.CatKey3},
                    CAT_KEY4            = {cat.CatKey4},
                    CAT_LIB_GROUP       = {cat.CatLibGroup},
                    TEMPLATE_ID         = {cat.TemplateId},
                    CAT_RESTRICT        = {cat.CatRestrict},
                    CAT_SECURITY        = {cat.CatSecurity},
                    CAT_OPER            = {cat.CatOper},
                    CAT_DATETIME        = {cat.CatDatetime}
                WHERE CAT_NO = {cat.CatNo}");
        }

        public async Task DeleteAsync(int catNo)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync(
                $"DELETE FROM CATALOGUE WHERE CAT_NO = {catNo}");
        }

        public async Task SavePictureAsync(int catNo, string filename, string mimeType, byte[] data)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($@"
                UPDATE CATALOGUE SET
                    CAT_PIC_FILENAME = {filename},
                    CAT_PIC_TYPE     = {mimeType},
                    CAT_PIC_DATA     = {data}
                WHERE CAT_NO = {catNo}");
        }

        public async Task RemovePictureAsync(int catNo)
        {
            await _context.Database.ExecuteSqlInterpolatedAsync($@"
                UPDATE CATALOGUE SET
                    CAT_PIC_FILENAME = NULL,
                    CAT_PIC_TYPE     = NULL,
                    CAT_PIC_DATA     = NULL
                WHERE CAT_NO = {catNo}");
        }
    }
}
