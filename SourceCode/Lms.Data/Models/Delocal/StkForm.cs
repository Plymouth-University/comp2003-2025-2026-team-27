using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkForm
{
    public string StkForm1 { get; set; } = null!;

    public string? StkFormDesc { get; set; }

    public string? StkAllowLoan { get; set; }

    public string? StkFloating { get; set; }

    public string? StkIsevent { get; set; }

    public string? StkIsrecurringfee { get; set; }

    public int? OrderId { get; set; }

    public string? StkIsDiary { get; set; }

    public int? StkDiaryDayPlan { get; set; }

    public int? StkDiaryWeeklyPlan { get; set; }

    public decimal? StkCapacity { get; set; }

    public string LlCode { get; set; } = null!;

    public string LlGroup { get; set; } = null!;

    public string? StkIsDigital { get; set; }

    public string? StkIsWatermarked { get; set; }

    public string? StkIssueType { get; set; }
}
