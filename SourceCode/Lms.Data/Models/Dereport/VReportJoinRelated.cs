using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VReportJoinRelated
{
    public int AReport { get; set; }

    public string JoinCondition { get; set; } = null!;

    public string? Dbname { get; set; }

    public string Table1 { get; set; } = null!;

    public string Table2 { get; set; } = null!;
}
