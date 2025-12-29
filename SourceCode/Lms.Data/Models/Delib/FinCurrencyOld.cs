using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class FinCurrencyOld
{
    public string? FcCode { get; set; }

    public string? FcDesc { get; set; }

    public decimal? FcRate { get; set; }

    public DateTime? FcDate { get; set; }

    public string? FcSymbol { get; set; }
}
