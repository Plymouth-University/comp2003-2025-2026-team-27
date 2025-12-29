using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibMemosOld
{
    public string? LmType { get; set; }

    public string? LmDesc { get; set; }

    public string? LmValidStk { get; set; }

    public string? LmValidBor { get; set; }

    public string? LmShow { get; set; }

    public int? LmDays { get; set; }
}
