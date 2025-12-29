using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VBorType
{
    public string BtType { get; set; } = null!;

    public string? BtName { get; set; }

    public string? BtKeepHistory { get; set; }

    public int? BtMaxItems { get; set; }

    public string? BtStats { get; set; }

    public int? BtAgeFrom { get; set; }

    public int? BtAgeTo { get; set; }

    public int? BtExpDays { get; set; }

    public DateTime? BtExpDate { get; set; }

    public string? BtGroup { get; set; }

    public DateTime? BtReturnDate { get; set; }

    public int? BtMaxReserves { get; set; }

    public int? BtThreshold { get; set; }

    public string? BtInTransit { get; set; }

    public decimal? BtOverdueEmailCharge { get; set; }

    public int? OrderId { get; set; }
}
