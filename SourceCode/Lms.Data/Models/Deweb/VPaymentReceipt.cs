using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VPaymentReceipt
{
    public string? FinBor { get; set; }

    public int PayNo { get; set; }

    public decimal PayValue { get; set; }

    public DateTime PayTransDate { get; set; }

    public string? PayLocation { get; set; }

    public string? PayOperator { get; set; }

    public string? PayLibGroup { get; set; }

    public int? CashTill { get; set; }

    public string? FinType { get; set; }

    public DateTime? FinDate { get; set; }

    public string? FinLoc { get; set; }

    public string? FinName { get; set; }

    public string? FinItem { get; set; }

    public string? FinTitle { get; set; }

    public string? FinComments { get; set; }

    public decimal? FinValue { get; set; }

    public decimal? FinPaid { get; set; }

    public decimal? BorOwing { get; set; }
}
