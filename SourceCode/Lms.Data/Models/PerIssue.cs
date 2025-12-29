using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class PerIssue
{
    public int? PiPerNo { get; set; }

    public int? PiSubsNo { get; set; }

    public DateTime? PiDate { get; set; }

    public DateTime? PiRecdDate { get; set; }

    public string? PiDescription { get; set; }

    public DateTime? PiDueDate { get; set; }

    public int? PiQtySub { get; set; }

    public int? PiQtyRecd { get; set; }

    public string? PiClaim { get; set; }

    public string? PiSpecial { get; set; }

    public int? PiIssueNo { get; set; }

    public string? PiComments { get; set; }

    public int? PiCatRef { get; set; }

    public DateTime? PiLikelyDate { get; set; }
}
