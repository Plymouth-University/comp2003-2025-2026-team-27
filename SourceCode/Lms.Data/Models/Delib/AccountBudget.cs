using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AccountBudget
{
    public string? AcbAccount { get; set; }

    public int? AcbYear { get; set; }

    public decimal? AcbBudget { get; set; }

    public string? AcbLibGroup { get; set; }
}
