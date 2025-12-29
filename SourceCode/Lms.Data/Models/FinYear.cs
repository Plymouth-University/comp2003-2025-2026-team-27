using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinYear
{
    public int? FyYear { get; set; }

    public DateTime? FyStart { get; set; }

    public DateTime? FyEnd { get; set; }

    public string? FyLibGroup { get; set; }

    public string? FyCurUsed { get; set; }
}
