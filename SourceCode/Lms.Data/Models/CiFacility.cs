using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CiFacility
{
    public int? FacNo { get; set; }

    public string? FacDesc { get; set; }

    public string? FacKey { get; set; }

    public int? FacCatNo { get; set; }

    public string? FacHolClose { get; set; }

    public string? FacComments { get; set; }

    public string? FacBookings { get; set; }

    public string? FacEquipHire { get; set; }

    public string? FacPatron { get; set; }

    public decimal? FacCost { get; set; }

    public decimal? FacDeposit { get; set; }

    public string? FacBarCode { get; set; }

    public decimal? FacEUnits { get; set; }

    public decimal? FacEFeeHour { get; set; }

    public decimal? FacEFeeHalf { get; set; }

    public decimal? FacEFeeDay { get; set; }

    public decimal? FacEFeeWkend { get; set; }

    public decimal? FacEFeeWeek { get; set; }

    public decimal? FacEBond { get; set; }

    public decimal? FacEMax { get; set; }

    public string? FacStatsClass { get; set; }

    public DateTime? FacStartDate { get; set; }

    public DateTime? FacEndDate { get; set; }

    public decimal? FacEOcc { get; set; }

    public string? FacEDisc { get; set; }

    public string? FacEDiscsched { get; set; }
}
