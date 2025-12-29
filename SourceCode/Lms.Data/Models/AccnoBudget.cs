using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AccnoBudget
{
    public string? AnbGroup { get; set; }

    public int? AnbYear { get; set; }

    public decimal? AnbBudget { get; set; }

    public int? AnbPrevyear { get; set; }

    public decimal? AnbPrevactual { get; set; }

    public string? AnbGroup1 { get; set; }

    public string? AnbGroup2 { get; set; }

    public string? AnbGroup3 { get; set; }

    public string? AnbGroup4 { get; set; }

    public string? AnbLibGroup { get; set; }
}
