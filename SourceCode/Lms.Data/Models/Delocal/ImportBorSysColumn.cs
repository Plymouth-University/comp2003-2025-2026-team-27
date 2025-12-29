using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ImportBorSysColumn
{
    public int UniqueId { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string ColumnDesc { get; set; } = null!;
}
