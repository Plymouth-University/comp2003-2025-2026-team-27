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
        private readonly Lms.Data.Models.Decat.DecatContext _decat;

        public BorrowerRepository(DelibContext delib, DelocalContext delocal, Lms.Data.Models.Decat.DecatContext decat)
        {
            _delib = delib;
            _delocal = delocal;
            _decat = decat;
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
                // Fetch and increment BorNo from BoSystab
                var systab = await _delib.BoSystabs.FirstOrDefaultAsync();
                if (systab == null)
                {
                    systab = new BoSystab { BorNo = 1, BaAddrNo = 1 };
                    _delib.BoSystabs.Add(systab);
                }
                else
                {
                    systab.BorNo = (systab.BorNo ?? 0) + 1;
                }
                
                borrower.BorNo = systab.BorNo ?? 1;
                _delib.Borrowers.Add(borrower);
            }
            else
            {
                // Update existing
                var existing = await _delib.Borrowers.FindAsync(borrower.BorNo);
                if (existing == null) return false;

                _delib.Entry(existing).CurrentValues.SetValues(borrower);
            }
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteBorrowerAsync(int id)
        {
            var borrower = await _delib.Borrowers.FindAsync(id);
            if (borrower == null) return false;

            // Legacy Check: Borrowers with active loans cannot be deleted
            if (!string.IsNullOrEmpty(borrower.BorBarNo))
            {
                var hasLoans = await _delib.StkItems.AnyAsync(s => s.StkBorBarNo == borrower.BorBarNo);
                if (hasLoans) return false;
            }

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
        private const string FILE_TYPE_BORROWER = "B";
        private const string ACCESS_GLOBAL = "GLOBAL";

        public async Task<List<FileSetName>> GetFileSetsByOperatorAsync(string operatorName, int page, int pageSize)
        {
            return await _delib.FileSetNames
                .Where(f => f.FileNumber > 0 && f.FileType == FILE_TYPE_BORROWER && f.FileOper == operatorName && f.FileOperAccess != ACCESS_GLOBAL)
                .OrderBy(f => f.FileDesc)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<PagedResult<FileSetName>> GetFileSetsByCreatorAsync(
            string creatorName, 
            int page, 
            int pageSize, 
            string sortBy = "FileDesc", 
            string sortOrder = "ASC",
            string? searchTerm = null)
        {
            var query = _delib.FileSetNames.Where(f => f.FileNumber > 0 && f.FileType == FILE_TYPE_BORROWER);

            // 1. Filter by Creator
            if (creatorName == "SYSGLOBALFILES")
            {
                query = query.Where(f => f.FileOperAccess == ACCESS_GLOBAL);
            }
            else
            {
                query = query.Where(f => f.FileOper == creatorName && f.FileOperAccess != ACCESS_GLOBAL);
            }

            // 2. Search
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query = query.Where(f => f.FileDesc != null && f.FileDesc.Contains(searchTerm.Trim()));
            }

            // 3. Count
            var totalItems = await query.CountAsync();

            // 4. Dynamic Sorting
            bool isDesc = sortOrder?.ToUpper() == "DESC";
            query = sortBy switch
            {
                "FileDate" => isDesc ? query.OrderByDescending(f => f.FileDate) : query.OrderBy(f => f.FileDate),
                "FileQty" => isDesc ? query.OrderByDescending(f => f.FileQty) : query.OrderBy(f => f.FileQty),
                _ => isDesc ? query.OrderByDescending(f => f.FileDesc) : query.OrderBy(f => f.FileDesc)
            };

            // 5. Paginate
            var items = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new PagedResult<FileSetName>
            {
                Items = items,
                TotalItems = totalItems,
                Page = page,
                PageSize = pageSize
            };
        }

        public async Task<int> GetFileSetsCountByOperatorAsync(string operatorName)
        {
            return await _delib.FileSetNames
                .Where(f => f.FileNumber > 0 && f.FileType == FILE_TYPE_BORROWER && f.FileOper == operatorName && f.FileOperAccess != ACCESS_GLOBAL)
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
            // Delete reading list links first
            var links = await _delib.AFileSetLibCats.Where(l => l.FileNumberLib == fileNumber).ToListAsync();
            _delib.AFileSetLibCats.RemoveRange(links);

            // Delete members
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

        public async Task<List<FileSetName>> GetWritableFileSetsAsync(string operatorName)
        {
            // Can write if Owner OR access is FULL ('A') OR GLOBAL ('GLOBAL')
            return await _delib.FileSetNames
                .Where(f => f.FileNumber > 0 && f.FileType == FILE_TYPE_BORROWER && 
                           (f.FileOper == operatorName || f.FileOperAccess == "A" || f.FileOperAccess == ACCESS_GLOBAL))
                .OrderBy(f => f.FileDesc)
                .ToListAsync();
        }

        public async Task<int> AddBorrowersToFileAsync(int fileNumber, List<int> borNos)
        {
            if (borNos == null || borNos.Count == 0) return 0;

            // 1. Filter out already existing links
            var existingBorNos = await _delib.FileSetData
                .Where(f => f.FileNumber == fileNumber && borNos.Contains(f.FileNitem ?? 0))
                .Select(f => f.FileNitem ?? 0)
                .ToListAsync();

            var newBorNos = borNos.Except(existingBorNos).ToList();
            if (newBorNos.Count == 0) return 0;

            // 2. Batch insert using raw SQL (efficient)
            int rowsAffected = 0;
            foreach (var borNo in newBorNos)
            {
                var sql = "INSERT INTO FILE_SET_DATA (FILE_NUMBER, FILE_NITEM) VALUES ({0}, {1})";
                rowsAffected += await _delib.Database.ExecuteSqlRawAsync(sql, fileNumber, borNo);
            }

            // 3. Update quantity in header
            if (rowsAffected > 0)
            {
                var updateSql = "UPDATE FILE_SET_NAMES SET FILE_QTY = (SELECT COUNT(*) FROM FILE_SET_DATA WHERE FILE_NUMBER = {0}) WHERE FILE_NUMBER = {0}";
                await _delib.Database.ExecuteSqlRawAsync(updateSql, fileNumber);
            }

            return rowsAffected;
        }

        public async Task<int> RemoveBorrowersFromFileAsync(int fileNumber, List<int> borNos)
        {
            if (borNos == null || borNos.Count == 0) return 0;

            // Get the barcodes for these IDs to ensure we can remove legacy records too
            var barcodes = await _delib.Borrowers
                .Where(b => borNos.Contains(b.BorNo))
                .Select(b => b.BorBarNo)
                .Where(b => b != null)
                .ToListAsync();

            // Build a flexible delete query that matches on ID OR Barcode
            // We use parameters for safety
            var borNosList = string.Join(",", borNos);
            var barcodesList = barcodes.Count > 0 ? "'" + string.Join("','", barcodes) + "'" : "''";

            var sql = $"DELETE FROM FILE_SET_DATA WHERE FILE_NUMBER = {{0}} AND (FILE_NITEM IN ({borNosList}) OR FILE_ITEM IN ({barcodesList}))";
            int rowsAffected = await _delib.Database.ExecuteSqlRawAsync(sql, fileNumber);

            // Update quantity in header
            if (rowsAffected > 0)
            {
                var updateSql = "UPDATE FILE_SET_NAMES SET FILE_QTY = (SELECT COUNT(*) FROM FILE_SET_DATA WHERE FILE_NUMBER = {0}) WHERE FILE_NUMBER = {0}";
                await _delib.Database.ExecuteSqlRawAsync(updateSql, fileNumber);
            }

            return rowsAffected;
        }

        public async Task<List<Lms.Data.Models.Decat.FileCatName>> GetGeneralCatalogFilesAsync()
        {
            return await _decat.FileCatNames
                .Where(f => f.ListType == "G")
                .OrderBy(f => f.FileDesc)
                .ToListAsync();
        }

        public async Task<List<AFileSetLibCat>> GetRelatedReadingListsAsync(int borrowerFileNumber)
        {
            return await _delib.AFileSetLibCats
                .Where(l => l.FileNumberLib == borrowerFileNumber)
                .ToListAsync();
        }

        public async Task<bool> SaveRelatedReadingListsAsync(int borrowerFileNumber, List<AFileSetLibCat> links)
        {
            // Remove existing links
            var existing = await _delib.AFileSetLibCats
                .Where(l => l.FileNumberLib == borrowerFileNumber)
                .ToListAsync();
            _delib.AFileSetLibCats.RemoveRange(existing);

            // Add new links
            if (links != null && links.Count > 0)
            {
                foreach (var link in links)
                {
                    link.FileNumberLib = borrowerFileNumber;
                    _delib.AFileSetLibCats.Add(link);
                }
            }

            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<BorAddr?> GetMainAddressAsync(int borNo)
        {
            return await _delib.BorAddrs.FirstOrDefaultAsync(a => a.BaBorNo == borNo && a.BaMain == true);
        }

        // --- Search ---

        public async Task<PagedResult<BorrowerWithAddress>> SearchBorrowersAsync(
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
            string sortOrder)
        {
            var query = _delib.Borrowers.AsQueryable();

            // 0. File List Filter: Join with FILE_SET_DATA if fileNumber is provided
            if (fileNumber.HasValue)
            {
                // Improved Join: Check both FileNitem (ID) and FileItem (Barcode) for maximum compatibility
                // Order by FileSequence as per legacy logic
                query = from b in query
                        join f in _delib.FileSetData on fileNumber.Value equals f.FileNumber
                        where b.BorNo == f.FileNitem || (b.BorBarNo != null && b.BorBarNo == f.FileItem)
                        orderby f.FileSequence
                        select b;
            }

            // 1. Security Filter: BOR_LIB_GROUP must be in allowedGroups
            if (allowedGroups != null && allowedGroups.Any())
            {
                query = query.Where(b => b.BorLibGroup != null && allowedGroups.Contains(b.BorLibGroup));
            }

            // 2. Dynamic Filtering
            if (!string.IsNullOrWhiteSpace(barcode))
                query = query.Where(b => b.BorBarNo == barcode.Trim());

            if (!string.IsNullOrWhiteSpace(surname))
                query = query.Where(b => b.BorSurname != null && b.BorSurname.StartsWith(surname.Trim()));

            if (!string.IsNullOrWhiteSpace(givenName))
                query = query.Where(b => b.BorGiven != null && b.BorGiven.StartsWith(givenName.Trim()));

            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(b => b.BorType == type);

            if (!string.IsNullOrWhiteSpace(group))
                query = query.Where(b => b.BorGroup == group);

            if (!string.IsNullOrWhiteSpace(className))
                query = query.Where(b => b.BorClass == className);

            if (!string.IsNullOrWhiteSpace(status))
                query = query.Where(b => b.BorStatus == status);

            if (!string.IsNullOrWhiteSpace(location))
                query = query.Where(b => b.BorLocation == location);

            if (!string.IsNullOrWhiteSpace(sex))
                query = query.Where(b => b.BorSex == sex);

            if (dob.HasValue)
            {
                var dobDate = DateOnly.FromDateTime(dob.Value);
                query = dobCondition switch
                {
                    "before" => query.Where(b => b.BorDob < dobDate),
                    "after" => query.Where(b => b.BorDob > dobDate),
                    _ => query.Where(b => b.BorDob == dobDate)
                };
            }

            // 3. Counting Total Results
            var totalItems = await query.CountAsync();

            // 4. Dynamic Sorting
            bool isDesc = sortOrder?.ToUpper() == "DESC";
            query = sortField switch
            {
                "BorBarNo" => isDesc ? query.OrderByDescending(b => b.BorBarNo) : query.OrderBy(b => b.BorBarNo),
                "BorGiven" => isDesc ? query.OrderByDescending(b => b.BorGiven) : query.OrderBy(b => b.BorGiven),
                "BorType" => isDesc ? query.OrderByDescending(b => b.BorType) : query.OrderBy(b => b.BorType),
                "BorGroup" => isDesc ? query.OrderByDescending(b => b.BorGroup) : query.OrderBy(b => b.BorGroup),
                "BorClass" => isDesc ? query.OrderByDescending(b => b.BorClass) : query.OrderBy(b => b.BorClass),
                "BorNoLoans" => isDesc ? query.OrderByDescending(b => b.BorNoLoans) : query.OrderBy(b => b.BorNoLoans),
                _ => isDesc ? query.OrderByDescending(b => b.BorSurname) : query.OrderBy(b => b.BorSurname)
            };

            // 5. Join with Address, calculate live loans, and Paginate
            var results = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .GroupJoin(
                    _delib.BorAddrs.Where(a => a.BaMain == true),
                    b => b.BorNo,
                    a => a.BaBorNo,
                    (b, addresses) => new { Borrower = b, MainAddress = addresses.FirstOrDefault() }
                )
                .ToListAsync();

            // Get live loan counts for these barcodes
            var barcodes = results.Select(r => r.Borrower.BorBarNo).Where(b => b != null).ToList();
            var liveLoanCounts = await _delib.StkItems
                .Where(s => s.StkBorBarNo != null && barcodes.Contains(s.StkBorBarNo))
                .GroupBy(s => s.StkBorBarNo)
                .Select(g => new { Barcode = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.Barcode!, x => x.Count);

            var finalItems = results.Select(r => {
                var item = new BorrowerWithAddress
                {
                    Borrower = r.Borrower,
                    FormattedAddress = r.MainAddress != null
                        ? string.Join(", ", new[] { r.MainAddress.BaAddr1, r.MainAddress.BaAddr2, r.MainAddress.BaSuburbCd }.Where(s => !string.IsNullOrWhiteSpace(s)))
                        : r.Borrower.BorAddr1Txt
                };
                
                // Override static loan count with live one
                if (r.Borrower.BorBarNo != null && liveLoanCounts.TryGetValue(r.Borrower.BorBarNo, out int count))
                {
                    item.Borrower.BorNoLoans = count;
                }
                else
                {
                    item.Borrower.BorNoLoans = 0;
                }

                return item;
            }).ToList();

            return new PagedResult<BorrowerWithAddress>
            {
                Items = finalItems,
                TotalItems = totalItems,
                Page = page,
                PageSize = pageSize
            };
        }
    }
}
