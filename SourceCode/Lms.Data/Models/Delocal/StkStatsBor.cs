using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkStatsBor
{
    public string? StkCode { get; set; }

    public string? BtType { get; set; }

    public string? BtName { get; set; }

    public string? BtAllowLoan { get; set; }

    public string? BtAllowRenew { get; set; }

    public string? BtAllowReserve { get; set; }

    public int? BtDays { get; set; }

    public int? BtQty { get; set; }

    public int? BtQtyRes { get; set; }

    public string? LlCode { get; set; }

    public decimal? BtIssCharge { get; set; }

    public decimal? BtRenCharge { get; set; }

    public decimal? BtResCharge { get; set; }

    public decimal? BtLatePday { get; set; }

    public decimal? BtLatePweek { get; set; }

    public decimal? BtLateMax { get; set; }

    public int? BtQtyRenew { get; set; }

    public int? BtGraceDays { get; set; }

    public decimal? BtHours { get; set; }

    public int? BtGraceHours { get; set; }

    public int? BtLatePhour { get; set; }

    public string? BtAllowRenewReserved { get; set; }

    public string BtOfferCollection { get; set; } = null!;

    public string BtOfferDelivery { get; set; } = null!;

    public decimal BtRecallSurchargePday { get; set; }
}
