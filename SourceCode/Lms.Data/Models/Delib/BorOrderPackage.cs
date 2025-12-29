using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorOrderPackage
{
    public int PackageId { get; set; }

    public string PackageLabel { get; set; } = null!;

    public string? DispatchLabel { get; set; }

    public DateTime? PackingDate { get; set; }

    public string? PackingBy { get; set; }

    public string? DeliveryReceiver { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryAddr1 { get; set; }

    public string? DeliveryAddr2 { get; set; }

    public string? DeliveryAddr3 { get; set; }

    public string? DeliveryAddr4 { get; set; }

    public string? DeliveryAddr5 { get; set; }

    public string? BaTelephone { get; set; }

    public string? BaPcode { get; set; }

    public string? BaAreaCd { get; set; }
}
