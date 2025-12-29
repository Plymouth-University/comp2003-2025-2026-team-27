using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AccnoHdr
{
    public int? AnhUnique { get; set; }

    public string? AnhDesc { get; set; }

    public int? AnhYear { get; set; }

    public decimal? AnhBudget { get; set; }

    public decimal? AnhActual { get; set; }

    public decimal? AnhCommit { get; set; }

    public string? AnhGroup1 { get; set; }

    public string? AnhGroup2 { get; set; }

    public string? AnhGroup3 { get; set; }

    public string? AnhGroup4 { get; set; }

    public string? AnhLibGroup { get; set; }
}
