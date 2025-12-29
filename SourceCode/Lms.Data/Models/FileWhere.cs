using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FileWhere
{
    public int? FwUniqueNo { get; set; }

    public string? FwDesc { get; set; }

    public string? FwWhere { get; set; }

    public string? FwOrder { get; set; }

    public string? FwType { get; set; }

    public string? FwOper { get; set; }

    public string? FwWhereEquation { get; set; }

    public string? IsGlobal { get; set; }
}
