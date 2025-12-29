using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorColumnsViewConfig
{
    public int Id { get; set; }

    public string ColumnId { get; set; } = null!;

    public string ColumnDesc { get; set; } = null!;

    public bool Isshow { get; set; }
}
