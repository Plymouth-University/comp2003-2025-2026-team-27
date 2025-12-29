using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkStatsCost
{
    public string? StkGroup { get; set; }

    public string? StkForm { get; set; }

    public decimal? StkDepreciation { get; set; }

    public int? StkLastYear { get; set; }

    public string? StkAccStr { get; set; }

    public int? StkFirstYear { get; set; }

    public decimal? StkMinCost { get; set; }

    public int? StkAvgYear { get; set; }
}
