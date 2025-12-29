using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VInvoiceComponent
{
    public int? AcHeaderNo { get; set; }

    public int? AcCompNo { get; set; }

    public int? AcLineNo { get; set; }

    public string? AcOrderNo { get; set; }

    public int? AcOrderLno { get; set; }

    public string? AcLine1 { get; set; }

    public string? AcLine2 { get; set; }

    public string? AcAccno { get; set; }

    public string? AcAlloc { get; set; }

    public string? AcTaxCode { get; set; }

    public decimal? AcTaxRate { get; set; }

    public string? AcTaxAccno { get; set; }

    public int? AcTaxTranNo { get; set; }

    public decimal? AcCost { get; set; }

    public decimal? AcTotal { get; set; }

    public int? AcTranNo { get; set; }

    public int? AcQtyInvoiced { get; set; }

    public string? AcNotes { get; set; }

    public string? AcStockitemyn { get; set; }

    public decimal? AcDiscount { get; set; }

    public string? AcDiscountInd { get; set; }
}
