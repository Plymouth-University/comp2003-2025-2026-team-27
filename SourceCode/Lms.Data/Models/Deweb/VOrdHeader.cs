using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VOrdHeader
{
    public string? OhOrderNo { get; set; }

    public string? OhSuppNo { get; set; }

    public string? OhSuppRef { get; set; }

    public DateTime? OhExpectedDate { get; set; }

    public string? OhGroupNo { get; set; }

    public string? OhSummary { get; set; }

    public string? OhKey { get; set; }

    public string? OhDescription { get; set; }

    public string? OhStatsCode { get; set; }

    public string? OhForm { get; set; }

    public int? OhCatRef { get; set; }

    public string? OhAccno { get; set; }

    public string? OhAlloc { get; set; }

    public decimal? OhCost { get; set; }

    public int? OhTranNo { get; set; }

    public DateTime? OhDatePlaced { get; set; }

    public DateTime? OhDatePrinted { get; set; }

    public string? OhFccode { get; set; }

    public decimal? OhFcvalue { get; set; }

    public decimal? OhFcrate { get; set; }

    public string? OhLibGroup { get; set; }

    public string? OhRecdAll { get; set; }

    public string? OhInvAll { get; set; }

    public string? OhPaid { get; set; }

    public string? OhOper { get; set; }

    public DateTime? OhDatetime { get; set; }

    public string? OhType { get; set; }

    public string? OhCondition { get; set; }

    public decimal? OhTotal { get; set; }

    public string? OhStatus { get; set; }

    public DateTime? OhDateToClaim { get; set; }

    public DateTime? OhFcdate { get; set; }

    public string? OhQuoteFlag { get; set; }

    public string? OhAuthoriseFlag { get; set; }

    public int? RotationPlanId { get; set; }
}
