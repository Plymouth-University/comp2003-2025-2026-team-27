using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportJoin
{
    public int AReportJoin1 { get; set; }

    public string JoinCondition { get; set; } = null!;

    public short ADatabase { get; set; }

    public string Table1 { get; set; } = null!;

    public string Table2 { get; set; } = null!;

    public virtual ATableAlias ATableAlias { get; set; } = null!;

    public virtual ATableAlias ATableAliasNavigation { get; set; } = null!;

    public virtual ICollection<AReport> AReports { get; set; } = new List<AReport>();
}
