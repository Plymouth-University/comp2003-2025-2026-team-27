using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VReportTableAlias
{
    public int AReport { get; set; }

    public string? Dbname { get; set; }

    public string ATableName { get; set; } = null!;

    public int TableOrder { get; set; }
}
