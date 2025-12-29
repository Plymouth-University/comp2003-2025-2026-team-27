using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VReportSummary
{
    public int? CatNo { get; set; }

    public int? UniqueNo { get; set; }

    public int? SfSequence { get; set; }

    public string? SummaryInfo { get; set; }

    public string? SummaryLabel { get; set; }
}
