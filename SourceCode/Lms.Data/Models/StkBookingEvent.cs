using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class StkBookingEvent
{
    public string StkItem { get; set; } = null!;

    public string BorBarNo { get; set; } = null!;

    public int? Status { get; set; }

    public decimal? Fee { get; set; }

    public decimal? CancellationFee { get; set; }

    public string? Anticipatedgrade { get; set; }

    public string? Notes { get; set; }

    public int? UniqueItemNo { get; set; }

    public int UniqueEventId { get; set; }

    public DateTime? StartDatetime { get; set; }

    public DateTime? EndDatetime { get; set; }

    public DateTime? ArrivedDateime { get; set; }

    public DateTime? DepartureDateime { get; set; }

    public bool? Allday { get; set; }

    public int? EventBorNo { get; set; }

    public string? EventType { get; set; }

    public bool? Isprivate { get; set; }

    public int? Quantity { get; set; }

    public double? UnitPrice { get; set; }
}
