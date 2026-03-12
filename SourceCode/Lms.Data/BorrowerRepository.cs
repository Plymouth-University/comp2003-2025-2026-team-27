using Lms.Data.Models.Delib;
using Lms.Data.Models.Delocal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lms.Data
{
    public class BorrowerRepository : IBorrowerRepository
    {
        private readonly DelibContext _delib;
        private readonly DelocalContext _delocal;

        public BorrowerRepository(DelibContext delib, DelocalContext delocal)
        {
            _delib = delib;
            _delocal = delocal;
        }

        public async Task<Borrower?> GetBorrowerByIdAsync(int id)
        {
            return await _delib.Borrowers.FirstOrDefaultAsync(b => b.BorNo == id);
        }

        public async Task<Borrower?> GetBorrowerByBarcodeAsync(string barcode)
        {
            if (string.IsNullOrWhiteSpace(barcode)) return null;
            return await _delib.Borrowers.FirstOrDefaultAsync(b => b.BorBarNo == barcode.Trim());
        }

        public async Task<bool> SaveBorrowerAsync(Borrower borrower)
        {
            if (borrower.BorNo == 0)
            {
                _delib.Borrowers.Add(borrower);
            }
            else
            {
                _delib.Borrowers.Update(borrower);
            }
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteBorrowerAsync(int id)
        {
            var borrower = await _delib.Borrowers.FindAsync(id);
            if (borrower == null) return false;

            _delib.Borrowers.Remove(borrower);
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<List<LookupItem>> GetBorrowerTypesAsync()
        {
            return await _delocal.BorTypes
                .OrderBy(t => t.OrderId)
                .Select(t => new LookupItem { Code = t.BtType, Name = t.BtName ?? t.BtType })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetBorrowerGroupsAsync()
        {
            return await _delocal.BorGroups
                .OrderBy(g => g.OrderId)
                .Select(g => new LookupItem { Code = g.BgGroup, Name = g.BgName ?? g.BgGroup })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetBorrowerClassesAsync()
        {
            return await _delocal.BorClasses
                .OrderBy(c => c.OrderId)
                .Select(c => new LookupItem { Code = c.BcClass, Name = c.BcName ?? c.BcClass })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetBorrowerStatusesAsync()
        {
            return await _delocal.BorStatuses
                .OrderBy(s => s.OrderId)
                .Select(s => new LookupItem { Code = s.BsType, Name = s.BsName ?? s.BsType })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetLocationsAsync()
        {
            return await _delocal.LibLocations
                .Select(l => new LookupItem { Code = l.LlCode, Name = l.LlName ?? l.LlCode })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetTitlesAsync()
        {
            return await _delocal.BorTitles
                .OrderBy(t => t.OrderId)
                .Select(t => new LookupItem { Code = t.BtTitle, Name = t.BtTitle })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetAreasAsync()
        {
            return await _delocal.Areas
                .OrderBy(a => a.OrderId)
                .Select(a => new LookupItem { Code = a.AreaCode, Name = a.AreaName ?? a.AreaCode })
                .ToListAsync();
        }

        public async Task<List<LookupItem>> GetWardsAsync()
        {
            return await _delocal.Wards
                .OrderBy(w => w.OrderId)
                .Select(w => new LookupItem { Code = w.WardCode, Name = w.WardName ?? w.WardCode })
                .ToListAsync();
        }

        // --- File Set Management ---

        public async Task<List<FileSetName>> GetFileSetsByOperatorAsync(string operatorName, int page, int pageSize)
        {
            return await _delib.FileSetNames
                .Where(f => f.FileOper == operatorName || f.FileOperAccess == "A")
                .OrderByDescending(f => f.FileDate)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetFileSetsCountByOperatorAsync(string operatorName)
        {
            return await _delib.FileSetNames
                .Where(f => f.FileOper == operatorName || f.FileOperAccess == "A")
                .CountAsync();
        }

        public async Task<FileSetName?> GetFileSetByNumberAsync(int fileNumber)
        {
            return await _delib.FileSetNames.FirstOrDefaultAsync(f => f.FileNumber == fileNumber);
        }

        public async Task<bool> SaveFileSetNameAsync(FileSetName fileSet)
        {
            if (fileSet.FileNumber == null || fileSet.FileNumber == 0)
            {
                // New record - Fetch next FileNumber from Systab
                var systab = await _delib.FileSetSystabs.FirstOrDefaultAsync();
                int nextNo = (systab?.FileNumber ?? 0) + 1;
                
                if (systab == null) {
                    _delib.FileSetSystabs.Add(new FileSetSystab { FileNumber = nextNo });
                } else {
                    systab.FileNumber = nextNo;
                }
                
                fileSet.FileNumber = nextNo;
                fileSet.FileDate = DateTime.Now;
                _delib.FileSetNames.Add(fileSet);
                return await _delib.SaveChangesAsync() > 0;
            }
            else
            {
                // Keyless update using raw SQL
                var sql = "UPDATE FILE_SET_NAMES SET FILE_DESC = {0}, FILE_OPER_ACCESS = {1} WHERE FILE_NUMBER = {2}";
                var rows = await _delib.Database.ExecuteSqlRawAsync(sql, fileSet.FileDesc ?? "", fileSet.FileOperAccess ?? "", fileSet.FileNumber);
                return rows > 0;
            }
        }

        public async Task<bool> DeleteFileSetAsync(int fileNumber)
        {
            // Delete members first
            await EmptyFileSetAsync(fileNumber);
            
            // Delete header
            var sql = "DELETE FROM FILE_SET_NAMES WHERE FILE_NUMBER = {0}";
            var rows = await _delib.Database.ExecuteSqlRawAsync(sql, fileNumber);
            return rows > 0;
        }

        public async Task<bool> EmptyFileSetAsync(int fileNumber)
        {
            var sql = "DELETE FROM FILE_SET_DATA WHERE FILE_NUMBER = {0}";
            await _delib.Database.ExecuteSqlRawAsync(sql, fileNumber);
            
            // Update quantity in header to 0
            var sqlHeader = "UPDATE FILE_SET_NAMES SET FILE_QTY = 0 WHERE FILE_NUMBER = {0}";
            await _delib.Database.ExecuteSqlRawAsync(sqlHeader, fileNumber);
            
            return true;
        }
    }
}
