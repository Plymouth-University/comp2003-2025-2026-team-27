using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AdFinTran
{
    public string? AuditType { get; set; }

    public string? FinType { get; set; }

    public DateTime? FinDate { get; set; }

    public string? FinOper { get; set; }

    public string? FinLoc { get; set; }

    public string? FinBor { get; set; }

    public string? FinName { get; set; }

    public string? FinItem { get; set; }

    public string? FinTitle { get; set; }

    public string? FinComments { get; set; }

    public decimal? FinQty { get; set; }

    public decimal? FinValue { get; set; }

    public string? FinCr { get; set; }

    public string? FinInvNo { get; set; }

    public DateTime? FinInvDate { get; set; }

    public decimal? FinPaid { get; set; }

    public int? FinTranNo { get; set; }

    public string? FinReport { get; set; }

    public int? FinReceipt { get; set; }

    public int? FinAccYear { get; set; }

    public string? FinAccount { get; set; }

    public string? FinSuppNo { get; set; }

    public string? FinCurrency { get; set; }

    public decimal? FinCurrRate { get; set; }

    public string? FinAllocCode { get; set; }

    public DateTime? FinDateMod { get; set; }

    public string? FinMarkfordelete { get; set; }

    public int? FinMfdRef { get; set; }

    public int? FinPaymentType { get; set; }

    public DateTime? AuditDate { get; set; }
}
