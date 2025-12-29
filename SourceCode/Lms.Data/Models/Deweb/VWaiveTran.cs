using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VWaiveTran
{
    public string WaiveType { get; set; } = null!;

    public DateTime? WaiveDate { get; set; }

    public string? WaiveOper { get; set; }

    public string? WaiveLoc { get; set; }

    public int WaiveBorno { get; set; }

    public int? WaiveItemno { get; set; }

    public string? WaiveName { get; set; }

    public string? WaiveTitle { get; set; }

    public string? WaiveComments { get; set; }

    public decimal? WaiveQty { get; set; }

    public decimal? WaiveValue { get; set; }

    public string? WaiveCr { get; set; }

    public string? WaiveInvNo { get; set; }

    public DateTime? WaiveInvDate { get; set; }

    public int? WaiveAccYear { get; set; }

    public string? WaiveAccount { get; set; }

    public string? WaiveSuppNo { get; set; }

    public string? WaiveCurrency { get; set; }

    public decimal? WaiveCurrRate { get; set; }

    public string? WaiveAllocCode { get; set; }

    public DateTime? WaiveDateMod { get; set; }

    public string? WaiveMarkfordelete { get; set; }

    public int WaiveUniqueId { get; set; }
}
