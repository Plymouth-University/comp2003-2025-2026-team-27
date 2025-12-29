using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Reportw
{
    public string? RepDesc { get; set; }

    public int? RepWhereNo { get; set; }

    public int? RepNumber { get; set; }

    public int? RepFileNo { get; set; }

    public int? RepOrderNo { get; set; }

    public int? RepStatsCode { get; set; }

    public int? RepSubStats { get; set; }

    public string? RepCreateHistory { get; set; }

    public string? RepUpdate { get; set; }

    public string? RepOper { get; set; }

    public DateTime? RepDatetime { get; set; }

    public string? RepLlCode { get; set; }
}
