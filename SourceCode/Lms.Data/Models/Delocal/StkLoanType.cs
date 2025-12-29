using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkLoanType
{
    public string StlLoanType { get; set; } = null!;

    public string? StlLoanDesc { get; set; }

    public string? StlNeverForLoan { get; set; }

    public string? StlOvernightOnly { get; set; }

    public int? StlDefaultDays { get; set; }

    public int? StlDefaultHours { get; set; }

    public int? StlLoanQty { get; set; }

    public string? StlAllowRenew { get; set; }

    public int? StlTimesRenew { get; set; }

    public int? OrderId { get; set; }

    public string LlCode { get; set; } = null!;

    public string LlGroup { get; set; } = null!;
}
