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
                int nextBorNo;
                int currentBaAddrNo = 1;

                if (systab == null)
                {
                    nextBorNo = 1;
                }
                else
                {
                    // EF Core cannot update properties that are part of the primary key.
                    // Since all properties of BoSystab are part of the primary key, we must delete and re-insert.
                    currentBaAddrNo = systab.BaAddrNo ?? 1;
                    nextBorNo = (systab.BorNo ?? 0) + 1;
                    _delib.BoSystabs.Remove(systab);
                }
                
                _delib.BoSystabs.Add(new BoSystab { BorNo = nextBorNo, BaAddrNo = currentBaAddrNo });
                
                borrower.BorNo = nextBorNo;
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
                .Select(t => new LookupItem { Code = t.BtTitle ?? "", Name = t.BtTitle ?? "" })
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
            if (allowedGroups != null)
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
                .Where(s => s.StkBorBarNo != null && barcodes.Contains(s.StkBorBarNo) && s.StkIsOnLoan == "Y")
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

        public async Task<BorAddr?> GetMainAddressAsync(int borNo)
        {
            return await _delib.BorAddrs
                .FirstOrDefaultAsync(a => a.BaBorNo == borNo && (a.BaMain == true || a.BaMailing == true));
        }

        public async Task<List<BorAddr>> GetBorrowerAddressesAsync(int borNo)
        {
            return await _delib.BorAddrs
                .Where(a => a.BaBorNo == borNo)
                .OrderByDescending(a => a.BaMain == true || a.BaMailing == true)
                .ThenBy(a => a.BaAddrNo)
                .ToListAsync();
        }

        public async Task<List<ABorAddressType>> GetAddressTypesAsync()
        {
            var dbTypes = await _delib.ABorAddressTypes.ToListAsync();
            
            // Following old system logic: 0: Correspondence, 1: Residential, 2: Guardian, 3: Guardian, 4: Order Delivery
            // With dynamic renaming via INST_BOR_ADDR1, 2, 3
            
            var label1 = await GetLabelTextAsync("INST_BOR_ADDR1") ?? "Correspondence";
            var label2 = await GetLabelTextAsync("INST_BOR_ADDR2") ?? "Residential";
            var label3 = await GetLabelTextAsync("INST_BOR_ADDR3") ?? "Guardian";

            var defaultTypes = new List<ABorAddressType>
            {
                new ABorAddressType { AddressTypeId = 0, AdddressTypeDescription = label1 },
                new ABorAddressType { AddressTypeId = 1, AdddressTypeDescription = label2 },
                new ABorAddressType { AddressTypeId = 2, AdddressTypeDescription = label3 },
                new ABorAddressType { AddressTypeId = 3, AdddressTypeDescription = "Guardian" },
                new ABorAddressType { AddressTypeId = 4, AdddressTypeDescription = "Order Delivery" }
            };

            // Merge: keep DB types, add defaults for 0-4 if they don't exist in DB
            // SPECIAL: if ID 2 and ID 3 both result in "Guardian", skip ID 3 to avoid duplicates
            foreach (var def in defaultTypes)
            {
                if (!dbTypes.Any(t => t.AddressTypeId == def.AddressTypeId))
                {
                    // Deduplicate by name for the generic ones
                    if (!dbTypes.Any(t => t.AdddressTypeDescription.Equals(def.AdddressTypeDescription, StringComparison.OrdinalIgnoreCase)))
                    {
                        dbTypes.Add(def);
                    }
                }
            }

            return dbTypes.OrderBy(t => t.AddressTypeId).ToList();
        }

        private async Task<string?> GetLabelTextAsync(string labelName)
        {
            // The old system might use different screen names, but we search by LabelName across all screens if needed
            // or specific screen if known. Let's try finding it by LabelName.
            var label = await _delocal.Ans247libLabels
                .FirstOrDefaultAsync(l => l.LabelName == labelName);
            
            return label?.LabelText;
        }

        public async Task<List<Lms.Data.Models.Delocal.Suburb>> GetSuburbsAsync()
        {
            return await _delocal.Suburbs
                .OrderBy(s => s.OrderId)
                .ThenBy(s => s.SuburbName)
                .ToListAsync();
        }

        public async Task<bool> SaveAddressAsync(BorAddr address)
        {
            if (address.BaAddrNo == 0)
            {
                // New address - get next BaAddrNo from BoSystab
                var systab = await _delib.BoSystabs.FirstOrDefaultAsync();
                int nextId;
                int currentBorNo = 1;

                if (systab != null)
                {
                    currentBorNo = systab.BorNo ?? 1;
                    nextId = (systab.BaAddrNo ?? 0) + 1;
                    // EF Core cannot update properties that are part of the primary key.
                    // Since all properties of BoSystab are part of the primary key, we must delete and re-insert.
                    _delib.BoSystabs.Remove(systab);
                }
                else
                {
                    nextId = 1;
                }
                
                // Safety: check if this ID already exists in BOR_ADDR (systab might be out of sync)
                var maxExisting = await _delib.BorAddrs.MaxAsync(a => (int?)a.BaAddrNo) ?? 0;
                if (nextId <= maxExisting)
                {
                    nextId = maxExisting + 1;
                }

                _delib.BoSystabs.Add(new BoSystab { BorNo = currentBorNo, BaAddrNo = nextId });

                address.BaAddrNo = nextId;
                _delib.BorAddrs.Add(address);
            }
            else
            {
                // Update existing
                var existing = await _delib.BorAddrs.FirstOrDefaultAsync(a => a.BaBorNo == address.BaBorNo && a.BaAddrNo == address.BaAddrNo);
                if (existing == null) return false;

                _delib.Entry(existing).CurrentValues.SetValues(address);
            }
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAddressAsync(int borNo, int addrNo)
        {
            var address = await _delib.BorAddrs.FirstOrDefaultAsync(a => a.BaBorNo == borNo && a.BaAddrNo == addrNo);
            if (address == null) return false;

            _delib.BorAddrs.Remove(address);
            return await _delib.SaveChangesAsync() > 0;
        }

        // --- Extended Management Actions ---

        public async Task<bool> ApproveRegistrationAsync(int borNo)
        {
            var borrower = await _delib.Borrowers.FindAsync(borNo);
            if (borrower == null) return false;

            borrower.BorApproved = "Y";
            borrower.BorDatetime = DateTime.Now;
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> RejectRegistrationAsync(int borNo)
        {
            var borrower = await _delib.Borrowers.FindAsync(borNo);
            if (borrower == null) return false;

            borrower.BorApproved = "N";
            borrower.BorRejectedEmail = "Y"; // Legacy flag for rejection
            borrower.BorDatetime = DateTime.Now;
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> ResetPinAsync(string barcode)
        {
            var borrower = await _delib.Borrowers.FirstOrDefaultAsync(b => b.BorBarNo == barcode);
            if (borrower == null) return false;

            // Simple random 4-digit PIN for legacy compatibility
            var rnd = new Random();
            borrower.BorPin = rnd.Next(1000, 9999).ToString();
            borrower.BorReqPinChange = "Y"; // Force change on next login
            borrower.BorDatetime = DateTime.Now;
            
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> SetRelationshipAsync(int borNo, int? parentBorNo, string relType)
        {
            var borrower = await _delib.Borrowers.FindAsync(borNo);
            if (borrower == null) return false;

            borrower.BorRelType = relType; // 'P'arent, 'C'hild, 'N'one
            // In legacy, relationships are often managed via BOR_REF fields or specific child tables
            // Here we update the main record
            borrower.BorDatetime = DateTime.Now;

            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> SetGroupRelationshipAsync(int borNo, int? groupParentBorNo)
        {
            var borrower = await _delib.Borrowers.FindAsync(borNo);
            if (borrower == null) return false;

            borrower.ParentBorNoSee = groupParentBorNo;
            borrower.BorDatetime = DateTime.Now;

            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<List<Borrower>> GetRelatedBorrowersAsync(int borNo)
        {
            // Find all borrowers where this is the parent or they share the same parent
            var borrower = await _delib.Borrowers.FindAsync(borNo);
            if (borrower == null) return new List<Borrower>();

            // Simplified logic: find others with same reference or linked IDs
            // Legacy apps use complex join logic; here we'll look for potential children
            return await _delib.Borrowers
                .Where(b => b.ParentBorNoSee == borNo || (borrower.ParentBorNoSee != null && b.ParentBorNoSee == borrower.ParentBorNoSee))
                .Take(100)
                .ToListAsync();
        }

        public async Task<List<Borrower>> GetRelatedGroupBorrowersAsync(int borNo)
        {
            return await _delib.Borrowers
                .Where(b => b.PreBorNoSee == borNo)
                .Take(100)
                .ToListAsync();
        }

        // --- History, Memos, Surveys, and ILR ---

        public async Task<List<BorHistory>> GetBorrowerHistoryAsync(int borNo)
        {
            var borrower = await GetBorrowerByIdAsync(borNo);
            if (borrower == null || string.IsNullOrEmpty(borrower.BorBarNo)) return new List<BorHistory>();

            return await _delib.BorHistories
                .Where(h => h.BorBarNo == borrower.BorBarNo)
                .OrderByDescending(h => h.BhDate)
                .ToListAsync();
        }

        public async Task<List<StkItem>> GetItemsOnLoanAsync(string barcode)
        {
            return await _delib.StkItems
                .Where(s => s.StkBorBarNo == barcode)
                .OrderBy(s => s.StkDateDue)
                .ToListAsync();
        }

        public async Task<List<StkHistory>> GetItemReturnHistoryAsync(string barcode)
        {
            return await _delib.StkHistories
                .Where(h => h.ShBorNo == barcode && h.ShType == "RETURN")
                .OrderByDescending(h => h.ShDate)
                .Take(50)
                .ToListAsync();
        }

        public async Task<List<BorMemo>> GetBorrowerMemosAsync(int borNo)
        {
            return await _delib.BorMemos
                .Where(m => m.BmBorNo == borNo)
                .OrderByDescending(m => m.BmEffDate)
                .ToListAsync();
        }

        public async Task<int> GetMemoCountAsync(int borNo)
        {
            return await _delib.BorMemos.CountAsync(m => m.BmBorNo == borNo);
        }

        public async Task<bool> SaveBorrowerMemoAsync(BorMemo memo)
        {
            if (string.IsNullOrEmpty(memo.BmUniqueNo))
            {
                memo.BmUniqueNo = Guid.NewGuid().ToString().Substring(0, 20);
                _delib.BorMemos.Add(memo);
            }
            else
            {
                var existing = await _delib.BorMemos.FirstOrDefaultAsync(m => m.BmBorNo == memo.BmBorNo && m.BmUniqueNo == memo.BmUniqueNo);
                if (existing == null) return false;
                _delib.Entry(existing).CurrentValues.SetValues(memo);
            }
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteBorrowerMemoAsync(int borNo, string uniqueNo)
        {
            var memo = await _delib.BorMemos.FirstOrDefaultAsync(m => m.BmBorNo == borNo && m.BmUniqueNo == uniqueNo);
            if (memo == null) return false;
            _delib.BorMemos.Remove(memo);
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<List<LookupItem>> GetMemoTypesAsync()
        {
            return await _delocal.LibMemos
                .OrderBy(m => m.LmDesc)
                .Select(m => new LookupItem { Code = m.LmType, Name = m.LmDesc ?? m.LmType })
                .ToListAsync();
        }

        public async Task<List<Survey>> GetAvailableSurveysAsync()
        {
            return await _delib.Surveys
                .Include(s => s.SurveysQuestions)
                    .ThenInclude(q => q.SurveysAnswers)
                .ToListAsync();
        }

        public async Task<BorSurvey?> GetBorrowerSurveyAsync(int borNo, int surveyId)
        {
            return await _delib.BorSurveys
                .Include(s => s.BorAnswers)
                .FirstOrDefaultAsync(s => s.BorNo == borNo && s.SurveyId == surveyId);
        }

        public async Task<Lms.Data.Models.Delib.IlrField?> GetBorrowerILRAsync(int borNo)
        {
            return await _delib.IlrFields.FirstOrDefaultAsync(f => f.BorNo == borNo);
        }

        public async Task<Lms.Data.Models.Delib.IlrAdditionalField?> GetBorrowerILRAdditionalAsync(int borNo)
        {
            return await _delib.IlrAdditionalFields.FirstOrDefaultAsync(f => f.Borno == borNo);
        }

        public async Task<bool> SaveBorrowerILRAsync(IlrField field, IlrAdditionalField additional)
        {
            var existingField = await _delib.IlrFields.FirstOrDefaultAsync(f => f.BorNo == field.BorNo);
            if (existingField == null) _delib.IlrFields.Add(field);
            else _delib.Entry(existingField).CurrentValues.SetValues(field);

            var existingAdd = await _delib.IlrAdditionalFields.FirstOrDefaultAsync(f => f.Borno == additional.Borno);
            if (existingAdd == null) _delib.IlrAdditionalFields.Add(additional);
            else _delib.Entry(existingAdd).CurrentValues.SetValues(additional);

            return await _delib.SaveChangesAsync() > 0;
        }

        // --- Picture Management ---

        public async Task<ABorPicture?> GetBorrowerPictureAsync(int borNo)
        {
            return await _delib.ABorPictures.FirstOrDefaultAsync(p => p.BorNo == borNo);
        }

        public async Task<bool> SaveBorrowerPictureAsync(ABorPicture picture)
        {
            var existing = await _delib.ABorPictures.FirstOrDefaultAsync(p => p.BorNo == picture.BorNo);
            if (existing == null)
            {
                _delib.ABorPictures.Add(picture);
            }
            else
            {
                _delib.Entry(existing).CurrentValues.SetValues(picture);
            }
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteBorrowerPictureAsync(int borNo)
        {
            var picture = await _delib.ABorPictures.FirstOrDefaultAsync(p => p.BorNo == borNo);
            if (picture == null) return false;
            _delib.ABorPictures.Remove(picture);
            return await _delib.SaveChangesAsync() > 0;
        }

        // --- Course Management ---

        public async Task<List<BorCoursePeriod>> GetBorrowerCoursePeriodsAsync(int borNo)
        {
            return await _delib.BorCoursePeriods
                .Where(p => p.BorNo == borNo)
                .ToListAsync();
        }

        public async Task<bool> SaveBorCoursePeriodAsync(BorCoursePeriod period)
        {
            _delib.BorCoursePeriods.Add(period);
            return await _delib.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteBorCoursePeriodAsync(int borNo, string coCode, DateTime from, DateTime to)
        {
            var period = await _delib.BorCoursePeriods.FirstOrDefaultAsync(p => 
                p.BorNo == borNo && 
                p.BorCoCode == coCode && 
                p.BorCpDateFrom == from && 
                p.BorCpDateTo == to);
            
            if (period == null) return false;
            _delib.BorCoursePeriods.Remove(period);
            return await _delib.SaveChangesAsync() > 0;
        }

        // --- Relationships ---

        public async Task<List<Borrower>> GetRelatedBorrowersByParentAsync(int parentBorNo)
        {
            return await _delib.Borrowers
                .Where(b => b.ParentBorNoSee == parentBorNo || b.BorNo == parentBorNo)
                .OrderBy(b => b.BorSurname)
                .ToListAsync();
        }

        // --- Finance ---

        public async Task<List<FinTran>> GetFinTransactionsAsync(string barcode)
        {
            if (string.IsNullOrEmpty(barcode)) return new List<FinTran>();
            
            return await _delib.FinTrans
                .Where(t => t.FinBor == barcode)
                .OrderByDescending(t => t.FinDate)
                .ToListAsync();
        }
    }
}
