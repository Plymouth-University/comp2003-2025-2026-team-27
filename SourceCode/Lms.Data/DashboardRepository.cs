using Lms.Data.Models.Delib;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data
{
    public class DashboardRepository : IDashboardRepository
    {

        private readonly DelibContext _delib;
        private readonly ILogger<DashboardRepository> _logger;
        public DashboardRepository(DelibContext delib, ILogger<DashboardRepository> logger)
        {
            _delib = delib;
            _logger = logger;

            // Log the actual connection string being used at runtime
            _logger.LogInformation("DELIB connection string in use: {ConnStr}", _delib.Database.GetDbConnection().ConnectionString);
        }

        public async Task<int> GetTotalMemberCountAsync()
        {
            // Borrower count from dbo.BORROWER
            return await _delib.Borrowers.CountAsync();

            
        }

        public async Task<int> GetTotalBookCountAsync()
        {
            // Use a NEW SqlConnection so we don't touch/dispose the DbContext's shared connection.
            var connStr = _delib.Database.GetConnectionString();
            if (string.IsNullOrWhiteSpace(connStr))
                throw new InvalidOperationException("DelibContext has no connection string. Check Program.cs + appsettings.json DelibConnection.");

            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            await using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
SELECT COUNT(DISTINCT ia.ISSUE_ITEM)
FROM dbo.ISSUE_AUDIT ia
WHERE ia.ISSUE_ITEM IS NOT NULL;
";
                var scalar = await cmd.ExecuteScalarAsync();
                return scalar is int i ? i : Convert.ToInt32(scalar);
            }
        

        public async Task<List<IssuesByBorrowerGroupDto>> GetIssuesByBorrowerGroupAsync(DateTime fromDate, DateTime toDate)
        {
            // Inclusive date range: [fromDate 00:00:00] to [toDate 23:59:59.9999999]
            var from = fromDate.Date;
            var toExclusive = toDate.Date.AddDays(1); // use < toExclusive

            var connStr = _delib.Database.GetConnectionString();
            if (string.IsNullOrWhiteSpace(connStr))
                throw new InvalidOperationException("DelibContext has no connection string. Check Program.cs + appsettings.json DelibConnection.");

            var results = new List<IssuesByBorrowerGroupDto>();

            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            await using var cmd = conn.CreateCommand();
            cmd.CommandText = @"
SELECT 
    ISNULL(NULLIF(LTRIM(RTRIM(b.BOR_GROUP)), ''), 'Unknown') AS GroupName,
    COUNT(*) AS IssueCount
FROM dbo.ISSUE_AUDIT ia
JOIN dbo.BORROWER b
    ON CONVERT(varchar(25), b.BOR_NO) = ia.ISSUE_BORROWER
WHERE ia.ISSUE_DATE >= @fromDate
  AND ia.ISSUE_DATE <  @toDateExclusive
GROUP BY ISNULL(NULLIF(LTRIM(RTRIM(b.BOR_GROUP)), ''), 'Unknown')
ORDER BY IssueCount DESC;
";

            cmd.Parameters.Add(new SqlParameter("@fromDate", SqlDbType.DateTime) { Value = from });
            cmd.Parameters.Add(new SqlParameter("@toDateExclusive", SqlDbType.DateTime) { Value = toExclusive });

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                results.Add(new IssuesByBorrowerGroupDto
                {
                    GroupName = reader.GetString(0),
                    IssueCount = reader.GetInt32(1)
                });
            }
        

            return results;
        }
    }
}
