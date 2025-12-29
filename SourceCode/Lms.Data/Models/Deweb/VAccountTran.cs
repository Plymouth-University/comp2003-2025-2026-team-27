using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAccountTran
{
    public int? AtrTranNo { get; set; }

    public string? AtrType { get; set; }

    public string? AtrAccount { get; set; }

    public decimal? AtrQty { get; set; }

    public decimal? AtrCost { get; set; }

    public decimal? AtrValue { get; set; }

    public string? AtrExtref1 { get; set; }

    public string? AtrExtref2 { get; set; }

    public string? AtrAmref1 { get; set; }

    public string? AtrAmref2 { get; set; }

    public string? AtrAmref3 { get; set; }

    public DateTime? AtrTransDate { get; set; }

    public string? AtrTransDesc { get; set; }

    public string? AtrLoc { get; set; }

    public string? AtrFccode { get; set; }

    public DateTime? AtrFcdate { get; set; }

    public decimal? AtrFccost { get; set; }

    public decimal? AtrFcvalue { get; set; }

    public decimal? AtrFcrate { get; set; }

    public string? AtrOper { get; set; }

    public DateTime? AtrDatetime { get; set; }

    public string? AtrAlloc { get; set; }

    public int? AtrFinYear { get; set; }

    public decimal? AtrCommit { get; set; }

    public decimal? AtrBudget { get; set; }

    public string? AtrStatus { get; set; }

    public string? AtrLibGroup { get; set; }

    public string? AtrRepeat { get; set; }

    public DateTime? AtrBeforeDate { get; set; }
}
