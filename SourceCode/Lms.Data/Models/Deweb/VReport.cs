using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VReport
{
    public int AReport { get; set; }

    public string? ReportName { get; set; }

    public string? ReportDescription { get; set; }

    public int AReportGroup { get; set; }

    public string AReportGroupDescription { get; set; } = null!;
}
