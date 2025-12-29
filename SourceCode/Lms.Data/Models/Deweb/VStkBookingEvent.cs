using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VStkBookingEvent
{
    public string StkItem { get; set; } = null!;

    public string BorBarNo { get; set; } = null!;

    public int? Status { get; set; }

    public decimal? Fee { get; set; }

    public decimal? CancellationFee { get; set; }

    public string? Anticipatedgrade { get; set; }

    public string? Notes { get; set; }

    public int? UniqueItemNo { get; set; }
}
