using Lms.Data;
using Lms.Data.Models.Delib;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Lms.Tests
{
    public class BorrowerRepositoryTests
    {
        // Deletion test code
        [Fact]
        public async Task DeleteBorrowerAsync_ShouldReturnFalse_WhenBorrowerHasActiveLoand()
        {
            // Setup In-Memory database for testing
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "DeleteTestDB_" + Guid.NewGuid())
                .Options;

            using (var context = new DelibContext(options))
            {
                // Create a borrower
                var borrower = new Borrower { BorNo = 1, BorBarNo = "BOR123", BorSurname = "Test" };
                context.Borrowers.Add(borrower);

                // Create active loan associated with the borrower
                var activeLoan = new StkItem { StkItemNo = "Item101", StkBorBarNo = "BOR123" };
                context.StkItems.Add(activeLoan);

                await context.SaveChangesAsync();
            }

            // Try to delete that borrower
            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null, null);
                var result = await repo.DeleteBorrowerAsync(1);

                // The logic should return False (deletion blocked)
                Assert.False(result);

                // Also verify borrowers still exists in database
                var exists = await context.Borrowers.AnyAsync(b => b.BorNo == 1);
                Assert.True(exists);
            }
        }

        // comprehensive paging test
        [Fact]
        public async Task SearchBorrowersAsync_ShouldOnlyReturnRequestedPageSize_RegardlessOfDatabaseSize()
        {
            // Setup In-Memory database for testing
            var options = new DbContextOptionsBuilder<DelibContext>()
                .UseInMemoryDatabase(databaseName: "PagingTestDB_" + Guid.NewGuid())
                .Options;

            var allowedGroups = new List<string> { "MAIN" };

            using (var context = new DelibContext(options))
            {
                // input 50 borrowers to simulate a large dataset
                for (int i = 1; i <= 1000; i++)
                {
                    context.Borrowers.Add(new Borrower
                    {
                        BorNo = i,
                        BorSurname = "User" + i.ToString("D3"), // User001, User002...
                        BorLibGroup = "MAIN"
                    });
                }
                await context.SaveChangesAsync();
            }

            using (var context = new DelibContext(options))
            {
                var repo = new BorrowerRepository(context, null, null);

                // Request Page 1 (Page size 20)
                var result = await repo.SearchBorrowersAsync(
                    null, null, null, null, null, null, null, null, null, null, null,
                    null, allowedGroups, 1, 20, "BorSurname", "ASC");

                // Assert 1. Only 20 items returned 2. Identify correct total items (Correctness) 3. Started at the beginning
                Assert.Equal(20, result.Items.Count);
                Assert.Equal(1000, result.TotalItems);
                Assert.Equal("User001", result.Items.First().Borrower.BorSurname);
            }
        }
    }
}