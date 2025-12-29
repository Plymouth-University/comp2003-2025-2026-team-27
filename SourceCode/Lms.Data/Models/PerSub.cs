using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class PerSub
{
    public int? PsSubsNo { get; set; }

    public string? PsLibGroup { get; set; }

    public DateTime? PsDate { get; set; }

    public string? PsComments { get; set; }

    public string? PsLlCode { get; set; }

    public string? PsOrderNo { get; set; }

    public string? PsIssn { get; set; }

    public int? PsQtySub { get; set; }

    public decimal? PsCost { get; set; }

    public int? PsPerNo { get; set; }

    public string? PsSuppNo { get; set; }

    public DateTime? PsRenewDue { get; set; }

    public DateTime? PsStartDate { get; set; }

    public decimal? PsCostIssue { get; set; }

    public int? PsOrderLno { get; set; }

    public int? PsQtyIssues { get; set; }

    public string? PsTitlePrefix { get; set; }

    public string? PsTitleSuffix { get; set; }

    public string? PsTitleFormat { get; set; }

    public int? PsCircList { get; set; }

    public DateTime? PsEndDate { get; set; }
}
