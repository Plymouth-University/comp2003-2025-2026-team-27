using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SalesItem
{
    public int SalesUniqueNo { get; set; }

    public int? FinTranNo { get; set; }

    public int? StkUniqueNo { get; set; }

    public string? StkDesc { get; set; }

    public decimal? Price { get; set; }

    public string? StkLocation { get; set; }

    public DateTime? LastUpdated { get; set; }
}
