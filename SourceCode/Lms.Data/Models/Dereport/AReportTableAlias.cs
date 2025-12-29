using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportTableAlias
{
    public int AReport { get; set; }

    public short ADatabase { get; set; }

    public string ATableName { get; set; } = null!;

    public int TableOrder { get; set; }

    public virtual AReport AReportNavigation { get; set; } = null!;

    public virtual ATableAlias ATableAlias { get; set; } = null!;
}
