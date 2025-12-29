using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TableViewConfig
{
    public int Id { get; set; }

    public string TabName { get; set; } = null!;

    public byte ColumnNum { get; set; }

    public int? DbColumnDescriptionId { get; set; }

    public byte? Rowid { get; set; }

    public byte? Columnid { get; set; }

    public string? BorType { get; set; }

    public string? BorGroups { get; set; }

    public string? BorClasses { get; set; }

    public virtual DbColumnDescription? DbColumnDescription { get; set; }
}
