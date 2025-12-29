using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class StockTake
{
    public int? StTakeNo { get; set; }

    public string? StClosed { get; set; }

    public string? StCallFrom { get; set; }

    public string? StCallTo { get; set; }

    public int? StTheoryCount { get; set; }

    public int? StLine { get; set; }

    public int? StActualCount { get; set; }

    public DateTime? StDateStart { get; set; }

    public DateTime? StDateEnd { get; set; }

    public string? StLastItem { get; set; }

    public string? StLastCall { get; set; }
}
