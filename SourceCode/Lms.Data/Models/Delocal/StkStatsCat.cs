using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkStatsCat
{
    public int? ScTag { get; set; }

    public string? ScInclude { get; set; }

    public string? ScExclude { get; set; }

    public string? ScNumber { get; set; }

    public string? ScStartsWith { get; set; }

    public string? ScStkCode { get; set; }
}
