using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkFormCat
{
    public int? SfTag { get; set; }

    public string? SfForm { get; set; }

    public string? SfInclude { get; set; }

    public string? SfExclude { get; set; }
}
