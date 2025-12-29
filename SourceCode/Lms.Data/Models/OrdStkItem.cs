using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class OrdStkItem
{
    public int? OsInvNo { get; set; }

    public int? OsCompNo { get; set; }

    public string? OsInstructions { get; set; }

    public string? OsLlCode { get; set; }

    public string? OsStkItemNo { get; set; }

    public DateTime? OsDateOrdered { get; set; }

    public DateTime? OsInvoiceDate { get; set; }

    public string? OsNewItemNo { get; set; }

    public string? OsAccessionNo { get; set; }

    public int? OsInvoiceCompNo { get; set; }

    public string? OsInvoicedyn { get; set; }

    public string? OsStatus { get; set; }

    public DateTime? OsStatusDate { get; set; }

    public int? OsRotationPlanId { get; set; }
}
