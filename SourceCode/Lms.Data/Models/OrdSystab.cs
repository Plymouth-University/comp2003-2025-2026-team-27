using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class OrdSystab
{
    public int? OrderNumber { get; set; }

    public int? CompNumber { get; set; }

    public int? ItemNumber { get; set; }

    public int? OrderlinesNo { get; set; }

    public string? OrdAccPart1 { get; set; }

    public string? OrdAccPart2 { get; set; }

    public string? OrdAccPart3 { get; set; }

    public string? OrdAccPart4 { get; set; }

    public string? OrdAccPart5 { get; set; }

    public string? OrdAccPart6 { get; set; }

    public int? OrdAccNo { get; set; }

    public int? InvoiceNumber { get; set; }

    public int? InvCompNumber { get; set; }
}
