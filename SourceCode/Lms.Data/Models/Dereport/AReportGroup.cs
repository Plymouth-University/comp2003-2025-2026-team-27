using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportGroup
{
    public int AReportGroup1 { get; set; }

    public string ReportGrpName { get; set; } = null!;

    public string? Flag { get; set; }

    public int? DefaultReport { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateTime { get; set; }

    public short? DeleteFlag { get; set; }

    public string? StandardLetter { get; set; }

    public string? IconImageGroup { get; set; }

    public string? IconContentType { get; set; }

    public byte[]? IconData { get; set; }

    public int? Position { get; set; }

    public virtual ICollection<AReport> AReports { get; set; } = new List<AReport>();

    public virtual ICollection<AValidEmailPlaceholder> AValidEmailPlaceholders { get; set; } = new List<AValidEmailPlaceholder>();
}
