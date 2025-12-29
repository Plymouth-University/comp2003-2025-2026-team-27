using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class PerStock
{
    public int? PstPerNo { get; set; }

    public string? PstLine1 { get; set; }

    public string? PstLine2 { get; set; }

    public string? PstLine3 { get; set; }

    public string? PstLine4 { get; set; }

    public string? PstLine5 { get; set; }

    public string? PstLine6 { get; set; }

    public string? PstForm { get; set; }

    public string? PstStatsCode { get; set; }

    public string? PstForLoan { get; set; }

    public string? PstAlertOper { get; set; }

    public string? PstOpacShow { get; set; }

    public string? PstLocTemp { get; set; }

    public string? PstLocFloor { get; set; }

    public string? PstProcess { get; set; }

    public DateTime? PstProcessDate { get; set; }

    public string? PstDescription { get; set; }

    public decimal? PstStkCost { get; set; }

    public int? PstSubsNo { get; set; }

    public int? PstCopy { get; set; }

    public string? PstLocPerm { get; set; }
}
