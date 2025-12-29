using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkFormRecurringFeeBor
{
    public string? StkForm { get; set; }

    public string? BtType { get; set; }

    public string? BtRenewalFreq { get; set; }

    public decimal? AdminFee { get; set; }

    public decimal? CancellationFee { get; set; }

    public decimal? LoyaltyBonus { get; set; }

    public decimal? DiscountPercent { get; set; }

    public DateTime? DiscountStartdate { get; set; }

    public DateTime? DiscountEnddate { get; set; }

    public string? LlCode { get; set; }
}
