using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CiEquipment
{
    public string? EqDesc { get; set; }

    public string? EqKey { get; set; }

    public string? EqBookingId { get; set; }

    public decimal? EqUnits { get; set; }

    public decimal? EqFeeHour { get; set; }

    public decimal? EqFeeDay { get; set; }

    public decimal? EqFeeWeekend { get; set; }

    public decimal? EqFeeWeek { get; set; }

    public decimal? EqBond { get; set; }

    public int? EqNo { get; set; }

    public int? EqFacNo { get; set; }

    public string? EqHourly { get; set; }

    public string? EqDaily { get; set; }

    public string? EqWeekly { get; set; }
}
