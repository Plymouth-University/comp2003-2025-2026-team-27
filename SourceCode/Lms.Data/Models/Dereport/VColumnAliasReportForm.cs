using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VColumnAliasReportForm
{
    public string? Dbname { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string AReportFormName { get; set; } = null!;
}
