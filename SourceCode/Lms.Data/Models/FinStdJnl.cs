using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinStdJnl
{
    public string? FinDesc { get; set; }

    public decimal? FinAmount { get; set; }

    public string? FinReport { get; set; }
}
