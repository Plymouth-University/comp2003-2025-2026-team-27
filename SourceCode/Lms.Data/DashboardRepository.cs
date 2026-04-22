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
    //Implements data queries following legacy frmDashboard.aspx logic
    public class DashboardRepository : IDashboardRepository
    {
        private readonly DelibContext _delib;
        private readonly ILogger<DashboardRepository> _logger;
        
        public DashboardRepository(DelibContext delib, ILogger<DashboardRepository> logger)
        {
            _delib = delib;
            _logger = logger;
        }

        public async Task<int> GetTotalMemberCountAsync()
        {
            return await _delib.Borrowers.CountAsync();
        }

        public async Task<(DateTime MinDate, DateTime MaxDate)> GetIssueDateRangeAsync()
        {
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            await using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MIN(ISSUE_DATE), MAX(ISSUE_DATE) FROM dbo.ISSUE_AUDIT";
            await using var reader = await cmd.ExecuteReaderAsync();
            await reader.ReadAsync();

            var min = reader.IsDBNull(0) ? DateTime.Today.AddDays(-7) : reader.GetDateTime(0);
            var max = reader.IsDBNull(1) ? DateTime.Today : reader.GetDateTime(1);

            return (min.Date, max.Date);
        }

        public async Task<int> GetTotalBookCountAsync()
        {
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();
            await using var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT COUNT(*) FROM dbo.STK_ITEM WHERE STK_ISS_DUE IS NOT NULL AND STK_BOR_BAR_NO <> STK_ITEM_NO";
            var result = await cmd.ExecuteScalarAsync();
            return result == DBNull.Value ? 0 : Convert.ToInt32(result);
        }

        public async Task<List<DashboardDistributionDto>> GetIssuesByDistributionAsync(string groupBy, DateTime fromDate, DateTime toDate, bool overdueOnly = false, int? fileNumber = null, string? operatorName = null)
        {
            var results = new List<DashboardDistributionDto>();
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            string column = GetBorrowerColumn(groupBy);
            string table = groupBy switch { "Class" => "BOR_CLASSES", "MemberType" => "BOR_TYPES", _ => "BOR_GROUPS" };
            string prefix = groupBy switch { "Class" => "BC", "MemberType" => "BT", _ => "BG" };
            string pk = groupBy switch { "Class" => "BC_CLASS", "MemberType" => "BT_TYPE", _ => "BG_GROUP" };
            
            string fileJoin = fileNumber.HasValue ? "JOIN dbo.FILE_SET_DATA fsd ON b.BOR_NO = fsd.FILE_NITEM AND fsd.FILE_NUMBER = @fileNumber" : "";
            string overdueFilter = overdueOnly ? "AND si.STK_ISS_DUE < SYSDATETIME()" : "";
            string operFilter = !string.IsNullOrEmpty(operatorName) ? "AND b.BOR_OPER = @oper" : "";

            await using var cmd = conn.CreateCommand();
            cmd.CommandText = $@"
WITH GroupedIssues AS (
    SELECT 
        ISNULL(NULLIF(LTRIM(RTRIM(ISNULL(tr.{prefix}_NAME, t.{prefix}_NAME))), ''), 'null') AS Label,
        COUNT(*) AS Count
    FROM dbo.STK_ITEM si
    JOIN dbo.BORROWER b ON si.STK_BOR_BAR_NO = b.BOR_BAR_NO
    LEFT JOIN DELOCAL.dbo.{table} t ON b.{column} = t.{pk}
    LEFT JOIN DELOCAL.dbo.{table}_TRANSLATION tr ON t.{pk} = tr.{pk} AND tr.LCID = 1033
    {fileJoin}
    WHERE si.STK_ISS_DUE IS NOT NULL 
      AND si.STK_BOR_BAR_NO <> si.STK_ITEM_NO
      {overdueFilter}
      {operFilter}
    GROUP BY ISNULL(NULLIF(LTRIM(RTRIM(ISNULL(tr.{prefix}_NAME, t.{prefix}_NAME))), ''), 'null')
),
TotalItems AS (
    SELECT COUNT(*) AS TotalCount FROM dbo.STK_ITEM WHERE STK_ISS_DUE IS NOT NULL AND STK_BOR_BAR_NO <> STK_ITEM_NO
)
SELECT 
    Label,
    Count,
    CASE WHEN (SELECT TotalCount FROM TotalItems) = 0 THEN 0 
         ELSE (CAST(Count AS FLOAT) / (SELECT TotalCount FROM TotalItems)) * 100 END AS Percentage
FROM GroupedIssues
ORDER BY Count DESC;
";

            if (fileNumber.HasValue) cmd.Parameters.Add(new SqlParameter("@fileNumber", SqlDbType.Int) { Value = fileNumber.Value });
            if (!string.IsNullOrEmpty(operatorName)) cmd.Parameters.Add(new SqlParameter("@oper", SqlDbType.NVarChar) { Value = operatorName });

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                results.Add(new DashboardDistributionDto 
                { 
                    Label = reader.GetString(0), 
                    Count = reader.GetInt32(1),
                    Percentage = reader.GetDouble(2)
                });
            }
            return results;
        }

        public async Task<List<DashboardDistributionDto>> GetCatalogueSubjectsAsync(int? fileNumber = null, string? operatorName = null, bool overdueOnly = false)
        {
            var results = new List<DashboardDistributionDto>();
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            string fileJoin = fileNumber.HasValue ? "JOIN dbo.FILE_SET_DATA fsd ON b.BOR_NO = fsd.FILE_NITEM AND fsd.FILE_NUMBER = @fileNumber" : "";
            string overdueFilter = overdueOnly ? "AND si.STK_ISS_DUE < SYSDATETIME()" : "";
            string operFilter = !string.IsNullOrEmpty(operatorName) ? "AND b.BOR_OPER = @oper" : "";

            await using var cmd = conn.CreateCommand();
            cmd.CommandText = $@"
WITH RawSubjectData AS (
    SELECT 
        si.STK_ITEM_NO,
        REPLACE(sd.SF_DATA, '.', '') as CleanedData
    FROM dbo.STK_ITEM si
    JOIN dbo.BORROWER b ON si.STK_BOR_BAR_NO = b.BOR_BAR_NO
    {fileJoin}
    LEFT JOIN DECAT.dbo.CATALOGUE_REFS cr ON si.STK_CAT_REF = cr.CAT_NO
    LEFT JOIN DECAT.dbo.CAT_TAG ct ON cr.CATTAG_NO = ct.TAG_NO AND ct.TAG_MARC IN ('600', '650', '651', '653')
    LEFT JOIN DECAT.dbo.SF_DATA sd ON ct.TAG_UNIQUE_NO = sd.SF_UNIQUE_NO AND sd.SF = 'a'
    WHERE si.STK_ISS_DUE IS NOT NULL 
      AND si.STK_BOR_BAR_NO <> si.STK_ITEM_NO
      {overdueFilter}
      {operFilter}
),
ProcessedSubjects AS (
    SELECT 
        CASE 
            WHEN CHARINDEX(',', CleanedData) > 0 AND (CHARINDEX('-', CleanedData) = 0 OR CHARINDEX(',', CleanedData) < CHARINDEX('-', CleanedData))
            THEN LTRIM(RTRIM(LEFT(CleanedData, CHARINDEX(',', CleanedData) - 1)))
            WHEN CHARINDEX('-', CleanedData) > 0 
            THEN LTRIM(RTRIM(LEFT(CleanedData, CHARINDEX('-', CleanedData) - 1)))
            ELSE ISNULL(NULLIF(LTRIM(RTRIM(CleanedData)), ''), 'null')
        END AS Label
    FROM RawSubjectData
),
GroupedSubjects AS (
    SELECT 
        Label,
        COUNT(*) AS Count
    FROM ProcessedSubjects
    GROUP BY Label
),
TotalLoans AS (
    SELECT COUNT(*) AS TotalCount FROM dbo.STK_ITEM WHERE STK_ISS_DUE IS NOT NULL AND STK_BOR_BAR_NO <> STK_ITEM_NO
)
SELECT 
    Label,
    Count,
    CASE WHEN (SELECT TotalCount FROM TotalLoans) = 0 THEN 0 
         ELSE (CAST(Count AS FLOAT) / (SELECT TotalCount FROM TotalLoans)) * 100 END AS Percentage
FROM GroupedSubjects
ORDER BY Count DESC;
";

            if (fileNumber.HasValue) cmd.Parameters.Add(new SqlParameter("@fileNumber", SqlDbType.Int) { Value = fileNumber.Value });
            if (!string.IsNullOrEmpty(operatorName)) cmd.Parameters.Add(new SqlParameter("@oper", SqlDbType.NVarChar) { Value = operatorName });

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                results.Add(new DashboardDistributionDto 
                { 
                    Label = reader.GetString(0), 
                    Count = reader.GetInt32(1),
                    Percentage = reader.GetDouble(2)
                });
            }
            return results;
        }

        public async Task<List<DashboardDistributionDto>> GetBorrowerDistributionAsync(string groupBy, int? fileNumber = null, string? operatorName = null)
        {
            var results = new List<DashboardDistributionDto>();
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            string column = GetBorrowerColumn(groupBy);
            string table = groupBy switch { "Class" => "BOR_CLASSES", "MemberType" => "BOR_TYPES", _ => "BOR_GROUPS" };
            string prefix = groupBy switch { "Class" => "BC", "MemberType" => "BT", _ => "BG" };
            string pk = groupBy switch { "Class" => "BC_CLASS", "MemberType" => "BT_TYPE", _ => "BG_GROUP" };

            string fileJoin = fileNumber.HasValue ? "JOIN dbo.FILE_SET_DATA fsd ON b.BOR_NO = fsd.FILE_NITEM AND fsd.FILE_NUMBER = @fileNumber" : "";
            string operFilter = !string.IsNullOrEmpty(operatorName) ? "WHERE b.BOR_OPER = @oper" : "";

            await using var cmd = conn.CreateCommand();
            cmd.CommandText = $@"
SELECT 
    ISNULL(NULLIF(LTRIM(RTRIM(ISNULL(tr.{prefix}_NAME, t.{prefix}_NAME))), ''), 'null') AS Label,
    COUNT(*) AS Count
FROM dbo.BORROWER b
LEFT JOIN DELOCAL.dbo.{table} t ON b.{column} = t.{pk}
LEFT JOIN DELOCAL.dbo.{table}_TRANSLATION tr ON t.{pk} = tr.{pk} AND tr.LCID = 1033
{fileJoin}
{operFilter}
GROUP BY ISNULL(NULLIF(LTRIM(RTRIM(ISNULL(tr.{prefix}_NAME, t.{prefix}_NAME))), ''), 'null')
ORDER BY Count DESC;
";

            if (fileNumber.HasValue) cmd.Parameters.Add(new SqlParameter("@fileNumber", SqlDbType.Int) { Value = fileNumber.Value });
            if (!string.IsNullOrEmpty(operatorName)) cmd.Parameters.Add(new SqlParameter("@oper", SqlDbType.NVarChar) { Value = operatorName });

            await using var reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                results.Add(new DashboardDistributionDto { Label = reader.GetString(0), Count = reader.GetInt32(1) });
            }
            return results;
        }

        public async Task<List<TrendDto>> GetHistoricalTrendsAsync(string trendType, DateTime fromDate, DateTime toDate, int? fileNumber = null, string? operatorName = null)
        {
            var results = new List<TrendDto>();
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            var groups = new List<string>();
            string groupByCol = "BOR_GROUP"; 
            
            await using (var gCmd = conn.CreateCommand())
            {
                string operFilter = !string.IsNullOrEmpty(operatorName) ? "AND b.BOR_OPER = @o" : "";
                if (trendType == "Loan")
                {
                    gCmd.CommandText = $@"SELECT DISTINCT ISNULL(NULLIF(LTRIM(RTRIM(b.{groupByCol})), ''), 'Unknown') 
                                        FROM dbo.STK_HISTORY sh JOIN dbo.BORROWER b ON sh.SH_BOR_NO = b.BOR_BAR_NO 
                                        WHERE sh.SH_TYPE = 'ISSUE' AND sh.SH_DATE >= @f AND sh.SH_DATE <= @t {operFilter}";
                }
                else
                {
                    gCmd.CommandText = $@"SELECT DISTINCT ISNULL(NULLIF(LTRIM(RTRIM(b.{groupByCol})), ''), 'Unknown') 
                                        FROM dbo.BORROWER b WHERE b.BOR_REGDATE >= @f AND b.BOR_REGDATE <= @t {operFilter}";
                }
                gCmd.Parameters.Add(new SqlParameter("@f", SqlDbType.DateTime) { Value = fromDate });
                gCmd.Parameters.Add(new SqlParameter("@t", SqlDbType.DateTime) { Value = toDate });
                if (!string.IsNullOrEmpty(operatorName)) gCmd.Parameters.Add(new SqlParameter("@o", SqlDbType.NVarChar) { Value = operatorName });
                
                await using var gReader = await gCmd.ExecuteReaderAsync();
                while (await gReader.ReadAsync()) groups.Add(gReader.GetString(0));
            }

            foreach (var groupName in groups.Take(10)) 
            {
                var points = new List<TrendPoint>();
                string operFilter = !string.IsNullOrEmpty(operatorName) ? "AND b.BOR_OPER = @oper" : "";
                string filterVal = groupName == "Unknown" ? $"ISNULL(NULLIF(LTRIM(RTRIM(b.{groupByCol})), ''), 'Unknown') = 'Unknown'" : $"b.{groupByCol} = @gName";
                
                string dataQuery;
                if (trendType == "Loan")
                {
                    dataQuery = $@"SELECT CAST(SH_DATE AS DATE) as D, COUNT(*) AS C FROM dbo.STK_HISTORY sh JOIN dbo.BORROWER b ON sh.SH_BOR_NO = b.BOR_BAR_NO 
                                  WHERE sh.SH_TYPE = 'ISSUE' AND {filterVal} AND sh.SH_DATE >= @f AND sh.SH_DATE <= @t {operFilter} GROUP BY CAST(SH_DATE AS DATE)";
                }
                else
                {
                    dataQuery = $@"SELECT CAST(BOR_REGDATE AS DATE) as D, COUNT(*) AS C FROM dbo.BORROWER b 
                                  WHERE {filterVal} AND b.BOR_REGDATE >= @f AND b.BOR_REGDATE <= @t {operFilter} GROUP BY CAST(BOR_REGDATE AS DATE)";
                }

                await using (var tCmd = conn.CreateCommand())
                {
                    tCmd.CommandText = $@"
WITH DateSeries AS (
    SELECT CAST(@f AS DATE) AS DDate
    UNION ALL
    SELECT DATEADD(DAY, 1, DDate) FROM DateSeries WHERE DDate < CAST(@t AS DATE)
)
SELECT ds.DDate, ISNULL(dq.C, 0)
FROM DateSeries ds
LEFT JOIN ({dataQuery}) dq ON ds.DDate = dq.D
OPTION (MAXRECURSION 32767);";

                    tCmd.Parameters.Add(new SqlParameter("@f", SqlDbType.DateTime) { Value = fromDate });
                    tCmd.Parameters.Add(new SqlParameter("@t", SqlDbType.DateTime) { Value = toDate });
                    if (groupName != "Unknown") tCmd.Parameters.Add(new SqlParameter("@gName", SqlDbType.NVarChar) { Value = groupName });
                    if (!string.IsNullOrEmpty(operatorName)) tCmd.Parameters.Add(new SqlParameter("@oper", SqlDbType.NVarChar) { Value = operatorName });

                    await using var tReader = await tCmd.ExecuteReaderAsync();
                    while (await tReader.ReadAsync())
                    {
                        points.Add(new TrendPoint { Date = tReader.GetDateTime(0), Count = tReader.GetInt32(1) });
                    }
                }
                results.Add(new TrendDto { Label = groupName, Points = points });
            }

            return results;
        }

        public async Task<PagedResult<BorrowerDrillDownDto>> GetBorrowerDrillDownAsync(string groupBy, string groupValue, string filterType, bool overdueOnly = false, int? fileNumber = null, string? operatorName = null, int page = 1, int pageSize = 10)
        {
            var connStr = _delib.Database.GetConnectionString();
            await using var conn = new SqlConnection(connStr);
            await conn.OpenAsync();

            string column = GetBorrowerColumn(groupBy);
            string table = groupBy switch { "Class" => "BOR_CLASSES", "MemberType" => "BOR_TYPES", _ => "BOR_GROUPS" };
            string prefix = groupBy switch { "Class" => "BC", "MemberType" => "BT", _ => "BG" };
            string pk = groupBy switch { "Class" => "BC_CLASS", "MemberType" => "BT_TYPE", _ => "BG_GROUP" };

            string fileJoin = fileNumber.HasValue ? "JOIN dbo.FILE_SET_DATA fsd ON b.BOR_NO = fsd.FILE_NITEM AND fsd.FILE_NUMBER = @fileNumber" : "";
            string loanJoin = filterType == "Loan" ? "JOIN dbo.STK_ITEM si ON b.BOR_BAR_NO = si.STK_BOR_BAR_NO AND si.STK_ISS_DUE IS NOT NULL" : "LEFT JOIN dbo.STK_ITEM si ON b.BOR_BAR_NO = si.STK_BOR_BAR_NO AND si.STK_ISS_DUE IS NOT NULL";
            string overdueFilter = overdueOnly ? "AND si.STK_ISS_DUE < SYSDATETIME()" : "";
            string operFilter = !string.IsNullOrEmpty(operatorName) ? "AND b.BOR_OPER = @oper" : "";
            
            string valueFilter;
            string lookupJoin = "";
            if (groupBy == "CatalogueSubject")
            {
                lookupJoin = @"LEFT JOIN DECAT.dbo.CATALOGUE_REFS cr ON si.STK_CAT_REF = cr.CAT_NO
                                LEFT JOIN DECAT.dbo.CAT_TAG ct ON cr.CATTAG_NO = ct.TAG_NO AND ct.TAG_MARC IN ('600', '650', '651', '653')
                                LEFT JOIN DECAT.dbo.SF_DATA sd ON ct.TAG_UNIQUE_NO = sd.SF_UNIQUE_NO AND sd.SF = 'a'";
                
                valueFilter = groupValue == "null" 
                    ? "ISNULL(NULLIF(LTRIM(RTRIM(REPLACE(sd.SF_DATA, '.', ''))), ''), 'null') = 'null'" 
                    : @"(CASE 
                            WHEN CHARINDEX(',', REPLACE(sd.SF_DATA, '.', '')) > 0 AND (CHARINDEX('-', REPLACE(sd.SF_DATA, '.', '')) = 0 OR CHARINDEX(',', REPLACE(sd.SF_DATA, '.', '')) < CHARINDEX('-', REPLACE(sd.SF_DATA, '.', '')))
                            THEN LTRIM(RTRIM(LEFT(REPLACE(sd.SF_DATA, '.', ''), CHARINDEX(',', REPLACE(sd.SF_DATA, '.', '')) - 1)))
                            WHEN CHARINDEX('-', REPLACE(sd.SF_DATA, '.', '')) > 0 
                            THEN LTRIM(RTRIM(LEFT(REPLACE(sd.SF_DATA, '.', ''), CHARINDEX('-', REPLACE(sd.SF_DATA, '.', '')) - 1)))
                            ELSE LTRIM(RTRIM(REPLACE(sd.SF_DATA, '.', '')))
                        END) = @groupValue";
            }
            else
            {
                lookupJoin = $@"LEFT JOIN DELOCAL.dbo.{table} lt ON b.{column} = lt.{pk}
                                LEFT JOIN DELOCAL.dbo.{table}_TRANSLATION ltr ON lt.{pk} = ltr.{pk} AND ltr.LCID = 1033";
                
                valueFilter = groupValue == "null" 
                    ? $"ISNULL(NULLIF(LTRIM(RTRIM(ISNULL(ltr.{prefix}_NAME, lt.{prefix}_NAME))), ''), 'null') = 'null'" 
                    : $"LTRIM(RTRIM(ISNULL(ltr.{prefix}_NAME, lt.{prefix}_NAME))) = @groupValue";
            }

            int totalCount = 0;
            await using (var countCmd = conn.CreateCommand())
            {
                countCmd.CommandText = $@"SELECT COUNT(DISTINCT b.BOR_NO) FROM dbo.BORROWER b {fileJoin} {loanJoin} {lookupJoin} WHERE {valueFilter} {overdueFilter} {operFilter}";
                if (groupValue != "null") countCmd.Parameters.Add(new SqlParameter("@groupValue", SqlDbType.NVarChar) { Value = groupValue });
                if (fileNumber.HasValue) countCmd.Parameters.Add(new SqlParameter("@fileNumber", SqlDbType.Int) { Value = fileNumber.Value });
                if (!string.IsNullOrEmpty(operatorName)) countCmd.Parameters.Add(new SqlParameter("@oper", SqlDbType.NVarChar) { Value = operatorName });
                totalCount = (int)(await countCmd.ExecuteScalarAsync() ?? 0);
            }

            var items = new List<BorrowerDrillDownDto>();
            await using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $@"
SELECT DISTINCT
    b.BOR_NO,
    b.BOR_BAR_NO,
    ISNULL(b.BOR_SURNAME, '') + ', ' + ISNULL(b.BOR_GIVEN, '') AS Name,
    b.BOR_TYPE,
    b.BOR_GROUP,
    b.BOR_CLASS,
    (SELECT COUNT(*) FROM dbo.STK_ITEM si2 WHERE si2.STK_BOR_BAR_NO = b.BOR_BAR_NO AND si2.STK_ISS_DUE IS NOT NULL AND si2.STK_BOR_BAR_NO <> si2.STK_ITEM_NO {overdueFilter.Replace("si.", "si2.")}) AS LoanCount
FROM dbo.BORROWER b
{fileJoin}
{loanJoin}
{lookupJoin}
WHERE {valueFilter}
{overdueFilter}
{operFilter}
ORDER BY b.BOR_NO
OFFSET @offset ROWS FETCH NEXT @limit ROWS ONLY";

                cmd.Parameters.Add(new SqlParameter("@offset", SqlDbType.Int) { Value = (page - 1) * pageSize });
                cmd.Parameters.Add(new SqlParameter("@limit", SqlDbType.Int) { Value = pageSize });
                if (groupValue != "null") cmd.Parameters.Add(new SqlParameter("@groupValue", SqlDbType.NVarChar) { Value = groupValue });
                if (fileNumber.HasValue) cmd.Parameters.Add(new SqlParameter("@fileNumber", SqlDbType.Int) { Value = fileNumber.Value });
                if (!string.IsNullOrEmpty(operatorName)) cmd.Parameters.Add(new SqlParameter("@oper", SqlDbType.NVarChar) { Value = operatorName });

                await using var reader = await cmd.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    items.Add(new BorrowerDrillDownDto
                    {
                        BorNo = reader.GetInt32(0),
                        Barcode = reader.IsDBNull(1) ? null : reader.GetString(1),
                        Name = reader.GetString(2),
                        Type = reader.IsDBNull(3) ? null : reader.GetString(3),
                        Group = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Class = reader.IsDBNull(5) ? null : reader.GetString(5),
                        LoanCount = reader.GetInt32(6)
                    });
                }
            }

            return new PagedResult<BorrowerDrillDownDto> { Items = items, TotalItems = totalCount, Page = page, PageSize = pageSize };
        }

        private string GetBorrowerColumn(string groupBy)
        {
            return groupBy switch
            {
                "Class" => "BOR_CLASS",
                "MemberType" => "BOR_TYPE",
                "Subject" => "BOR_GROUP",
                _ => "BOR_GROUP"
            };
        }

        public async Task<List<IssuesByBorrowerGroupDto>> GetIssuesByBorrowerGroupAsync(DateTime fromDate, DateTime toDate)
        {
            var dist = await GetIssuesByDistributionAsync("Group", fromDate, toDate);
            return dist.Select(d => new IssuesByBorrowerGroupDto { GroupName = d.Label, IssueCount = d.Count }).ToList();
        }
    }
}
