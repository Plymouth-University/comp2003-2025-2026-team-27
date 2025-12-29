using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CiDiscountDet
{
    public string? DdCode { get; set; }

    public string? DdPatIn { get; set; }

    public decimal? DdPercentage { get; set; }

    public string? DdDayIn { get; set; }

    public int? DdAfttime { get; set; }

    public int? DdBeftime { get; set; }
}
