using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CashCount
{
    public int CashCountId { get; set; }

    public int? ReconcileId { get; set; }

    public decimal? CashValue { get; set; }

    public int? TotalCount { get; set; }

    public decimal? TotalValue { get; set; }
}
