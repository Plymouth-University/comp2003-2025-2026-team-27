using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VPerCopy
{
    public string? PcDescription { get; set; }

    public int? PcIssueNo { get; set; }

    public DateTime? PcDateRecd { get; set; }

    public DateTime? PcExpDate { get; set; }

    public string? PcLlCode { get; set; }

    public string? PcInstructions { get; set; }

    public string? PcStkItemNo { get; set; }

    public int? PcCopyNo { get; set; }

    public int? PcSubsNo { get; set; }

    public string? PcClaimed { get; set; }

    public string? PcCallNo { get; set; }

    public string? PcForLoan { get; set; }

    public int? PcPerNo { get; set; }

    public decimal? PcCost { get; set; }

    public DateTime? PcLikelyDate { get; set; }

    public int? PcCopy { get; set; }
}
