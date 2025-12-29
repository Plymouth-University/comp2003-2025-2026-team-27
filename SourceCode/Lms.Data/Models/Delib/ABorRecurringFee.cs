using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ABorRecurringFee
{
    public int UniqueId { get; set; }

    public string BorBarNo { get; set; } = null!;

    public string StkItemNo { get; set; } = null!;

    public string? Frequency { get; set; }

    public string Description { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public bool AutoRenew { get; set; }

    public decimal? Fee { get; set; }

    public string Status { get; set; } = null!;

    public decimal? CancellationFee { get; set; }

    public int? DeleteFlag { get; set; }
}
