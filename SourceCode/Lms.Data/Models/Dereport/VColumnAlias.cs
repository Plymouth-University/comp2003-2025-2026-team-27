using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VColumnAlias
{
    public string? Dbname { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string ColumnAlias { get; set; } = null!;

    public string? ColumnDesc { get; set; }

    public int? Coltype { get; set; }

    public string? DataFormat { get; set; }

    public int? DefaultWidth { get; set; }

    public string DefaultHeading { get; set; } = null!;

    public int? Status { get; set; }

    public string? TemplateField { get; set; }
}
