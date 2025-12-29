using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkFormTcBor
{
    public string? StkForm { get; set; }

    public string? BtType { get; set; }

    public string BtAllowEvent { get; set; } = null!;

    public string? FeePayable { get; set; }

    public decimal Fee { get; set; }

    public string? CancellationFeeApplies { get; set; }

    public decimal? CancellationCharge { get; set; }

    public decimal? CancellationPerscent { get; set; }

    public string BookableOnline { get; set; } = null!;

    public string? LlCode { get; set; }
}
