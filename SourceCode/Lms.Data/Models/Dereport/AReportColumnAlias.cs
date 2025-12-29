using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportColumnAlias
{
    public int AReport { get; set; }

    public short ADatabase { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string Heading { get; set; } = null!;

    public int AggFunction { get; set; }

    public int FootFunction { get; set; }

    public int SortOrder { get; set; }

    public int Position { get; set; }

    public int? Width { get; set; }

    public string? DataFormat { get; set; }

    public int? Visible { get; set; }

    public string? FootLabel { get; set; }

    public string? TemplateField { get; set; }

    public bool? EmailFlag { get; set; }

    public virtual AColumnAlias AColumnAlias { get; set; } = null!;

    public virtual AReport AReportNavigation { get; set; } = null!;
}
