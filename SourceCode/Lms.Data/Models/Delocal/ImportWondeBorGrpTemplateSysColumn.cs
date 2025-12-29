using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ImportWondeBorGrpTemplateSysColumn
{
    public int Pkid { get; set; }

    public string? TblName { get; set; }

    public string? ColName { get; set; }

    public string? ColDesc { get; set; }

    public string? ColType { get; set; }

    public string? ColTypeDesc { get; set; }

    public bool UseForImport { get; set; }

    public int? SortId { get; set; }

    public int? SysColId { get; set; }
}
