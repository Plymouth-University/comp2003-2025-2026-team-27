using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AccountHeader
{
    public int? AhHeaderNo { get; set; }

    public string? AhInvoiceNo { get; set; }

    public string? AhLibGroup { get; set; }

    public string? AhSuppNo { get; set; }

    public string? AhSuppRef { get; set; }

    public decimal? AhTotal { get; set; }

    public decimal? AhCost { get; set; }

    public string? AhFccode { get; set; }

    public decimal? AhFcvalue { get; set; }

    public decimal? AhFcrate { get; set; }

    public DateTime? AhInvoiceDate { get; set; }

    public string? AhStatus { get; set; }

    public string? AhNotes { get; set; }

    public string? AhOper { get; set; }

    public DateTime? AhDatetime { get; set; }

    public DateTime? AhFcdate { get; set; }

    public DateTime? AhReportDate { get; set; }
}
