using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class FinTypesOld
{
    public string? FinAccno { get; set; }

    public string? FinDesc { get; set; }

    public string? FinType { get; set; }

    public decimal? FinStdCharge { get; set; }

    public decimal? FinCrBf { get; set; }

    public decimal? FinDbBf { get; set; }

    public int? FinCrCountBf { get; set; }

    public int? FinDbCountBf { get; set; }

    public decimal? FinIncludePercent { get; set; }
}
