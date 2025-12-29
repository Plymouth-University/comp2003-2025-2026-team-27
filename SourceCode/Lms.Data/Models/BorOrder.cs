using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorOrder
{
    public int OrderId { get; set; }

    public int? BorNo { get; set; }

    public DateTime? OrderDate { get; set; }

    public string? OrderBy { get; set; }

    public string? OrderStatus { get; set; }

    public int? DeliveryAddr { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryAddr1 { get; set; }

    public string? DeliveryAddr2 { get; set; }

    public string? DeliveryAddr3 { get; set; }

    public string? DeliveryAddr4 { get; set; }

    public string? DeliveryAddr5 { get; set; }

    public string? BaTelephone { get; set; }

    public string? BaPcode { get; set; }

    public string? BaAreaCd { get; set; }

    public DateTime? CompletedDate { get; set; }
}
