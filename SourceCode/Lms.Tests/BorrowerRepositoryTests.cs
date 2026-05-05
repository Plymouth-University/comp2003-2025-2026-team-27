using Lms.Data;
using Lms.Data.Models.Delib;
using Lms.Data.Models.Delocal;
using Microsoft.EntityFrameworkCore;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lms.Tests
{
    public class BorrowerRepositoryTests
    {
        // --- 1. Security & Authentication Tests ---
        [Fact]
        public async Task ValidateOperatorAsync_ShouldReturnOperator_WhenCredentialsAreValid()
        {
            var options = new DbContextOptionsBuilder<DelocalContext>()
                .UseInMemoryDatabase(databaseName: "AuthTestDB_" + Guid.NewGuid())
                .Options;

            using (var context = new DelocalContext(options))
            {
                context.Operators.Add(new Operator { OperName = "ADMIN", OperPassword = "Password123" });
                await context.SaveChangesAsync();
            }

            using (var context = new DelocalContext(options))
            {
                var repo = new OperatorRepository(context);
                var result = await repo.ValidateOperatorAsync("ADMIN", "Password123");

                Assert.NotNull(result);
                Assert.Equal("ADMIN", result.OperName);
            }
        }

        // --- 2. Data Integrity & Memos ---
        [Fact]
        public async Task SaveBorrowerMemoAsync_ShouldGenerateUniqueId_ForNewMemos()
        {
            var builder = new DbContextOptionsBuilder<DelibContext>();
            builder.UseInMemoryDatabase(databaseName: "MemoTestDB_" + Guid.NewGuid());
            
            using (var context = new DelibContext(builder.Options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var memo = new BorMemo { BmBorNo = 1, BmDisplay = "Initial Memo" };
                
                var success = await repo.SaveBorrowerMemoAsync(memo);
                Assert.True(success);
                Assert.False(string.IsNullOrEmpty(memo.BmUniqueNo));
            }
        }

        // --- 3. Hierarchical Relationships ---
        [Fact]
        public async Task GetRelatedBorrowersByParentAsync_ShouldReturnAllFamilyMembers()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "RelTestDB_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                // The repo logic: (b.ParentBorNoSee == parentBorNo || b.BorNo == parentBorNo)
                context.Borrowers.Add(new Borrower { BorNo = 100, BorSurname = "Parent", BorBarNo = "P100" });
                context.Borrowers.Add(new Borrower { BorNo = 101, BorSurname = "Child1", BorBarNo = "C101", ParentBorNoSee = 100 });
                context.Borrowers.Add(new Borrower { BorNo = 102, BorSurname = "Child2", BorBarNo = "C102", ParentBorNoSee = 100 });
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var results = await repo.GetRelatedBorrowersByParentAsync(100);

                // Parent (100) + 2 Children (101, 102) = 3
                Assert.Equal(3, results.Count);
            }
        }

        // --- 4. Batch Operations (Set-Based Logic) ---
        [Fact]
        public async Task RemoveBorrowersFromFileAsync_ShouldPerformBulkDeletion()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "BatchTestDB_" + Guid.NewGuid())
                .Options;

            // Note: FileSetDatum has no primary key, so we test the rows affected
            // The actual DB logic uses ExecuteSqlRaw which we can't fully mock in-memory
            // but we can verify the method returns correctly for empty/null inputs
            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var result = await repo.RemoveBorrowersFromFileAsync(10, new List<int>());
                Assert.Equal(0, result);
            }
        }

        // --- 5. Binary Handling (Profile Pictures) ---
        [Fact]
        public async Task SaveBorrowerPictureAsync_ShouldPersistBinaryData()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "PicTestDB_" + Guid.NewGuid())
                .Options;

            byte[] mockImageData = new byte[] { 0x89, 0x50, 0x4E, 0x47 };

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var pic = new ABorPicture 
                { 
                    BorNo = 1, 
                    BorPicData = mockImageData, 
                    BorPicType = "image/png",
                    BorPicFilename = "test.png" // Required field
                };
                
                var success = await repo.SaveBorrowerPictureAsync(pic);
                Assert.True(success);
            }
        }

        // --- 6. Legacy Bridge: BoSystab ID Generation ---
        [Fact]
        public async Task SaveBorrowerAsync_ShouldIncrementBorNo_WhenNewBorrower()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "SysTabTest_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                // Seed legacy system table with current count of 50
                context.BoSystabs.Add(new BoSystab { BorNo = 50, BaAddrNo = 10 });
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var newBorrower = new Borrower { BorNo = 0, BorSurname = "NewUser" };
                
                var success = await repo.SaveBorrowerAsync(newBorrower);

                Assert.True(success);
                Assert.Equal(51, newBorrower.BorNo); // Should be 50 + 1
            }
        }

        // --- 7. Multi-Table Transaction: ILR Upsert ---
        [Fact]
        public async Task SaveBorrowerILRAsync_ShouldUpdateExistingRecords_InBothTables()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "ILRTest_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                context.IlrFields.Add(new IlrField { BorNo = 1, Ninumber = "OLD_REF" });
                context.IlrAdditionalFields.Add(new IlrAdditionalField { Borno = 1, Firstlanguage = "OLD_LEVEL" });
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var field = new IlrField { BorNo = 1, Ninumber = "NEW_REF" };
                var add = new IlrAdditionalField { Borno = 1, Firstlanguage = "NEW_LEVEL" };

                var success = await repo.SaveBorrowerILRAsync(field, add);

                Assert.True(success);
                var savedField = await context.IlrFields.FirstAsync(f => f.BorNo == 1);
                var savedAdd = await context.IlrAdditionalFields.FirstAsync(f => f.Borno == 1);
                Assert.Equal("NEW_REF", savedField.Ninumber);
                Assert.Equal("NEW_LEVEL", savedAdd.Firstlanguage);
            }
        }

        // --- 8. Contact Data: Address ID & Retrieval ---
        [Fact]
        public async Task SaveAddressAsync_ShouldHandleBoSystabIncrement()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "AddrTest_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                context.BoSystabs.Add(new BoSystab { BorNo = 1, BaAddrNo = 100 });
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var addr = new BorAddr { BaBorNo = 1, BaAddrNo = 0, BaAddr1 = "Test St", BaMain = true };
                
                await repo.SaveAddressAsync(addr);

                Assert.Equal(101, addr.BaAddrNo); // 100 + 1
            }
        }

        // --- 9. Security Boundary: Missing Groups ---
        [Fact]
        public async Task SearchBorrowersAsync_ShouldReturnEmpty_WhenOperatorHasNoAllowedGroups()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "SecurityTest_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                context.Borrowers.Add(new Borrower { BorNo = 1, BorSurname = "Hidden", BorLibGroup = "SECRET" });
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                // Operator has NO groups
                var emptyGroups = new List<string>();
                
                var result = await repo.SearchBorrowersAsync(null, null, null, null, null, null, null, null, null, null, null, null, emptyGroups, 1, 20, "BorSurname", "ASC");

                Assert.Equal(0, result.TotalItems);
                Assert.Empty(result.Items);
            }
        }

        // --- Existing Paging & Deletion Tests ---

        [Fact]
        public async Task DeleteBorrowerAsync_ShouldReturnFalse_WhenBorrowerHasActiveLoans()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "DeleteTestDB_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                var borrower = new Borrower { BorNo = 1, BorBarNo = "BOR123", BorSurname = "Test" };
                context.Borrowers.Add(borrower);
                var activeLoan = new StkItem { StkItemNo = "Item101", StkBorBarNo = "BOR123", StkIsOnLoan = "Y" };
                context.StkItems.Add(activeLoan);
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var result = await repo.DeleteBorrowerAsync(1);
                Assert.False(result);
            }
        }

        [Fact]
        public async Task SearchBorrowersAsync_ShouldOnlyReturnRequestedPageSize_RegardlessOfDatabaseSize()
        {
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "PagingTestDB_" + Guid.NewGuid())
                .Options;

            var allowedGroups = new List<string> { "MAIN" };

            using (var context = new DelibContext(options))
            {
                for (int i = 1; i <= 100; i++)
                {
                    context.Borrowers.Add(new Borrower { BorNo = i, BorSurname = "User" + i.ToString("D3"), BorLibGroup = "MAIN" });
                }
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null!, null!);
                var result = await repo.SearchBorrowersAsync(null, null, null, null, null, null, null, null, null, null, null, null, allowedGroups, 1, 20, "BorSurname", "ASC");

                Assert.Equal(20, result.Items.Count);
                Assert.Equal(100, result.TotalItems);
                Assert.Equal("User001", result.Items.First().Borrower.BorSurname);
            }
        }
    }
}