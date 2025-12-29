using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkLoanTypesOld
{
    public string? StlLoanType { get; set; }

    public string? StlLoanDesc { get; set; }

    public string? StlNeverForLoan { get; set; }

    public string? StlOvernightOnly { get; set; }

    public int? StlDefaultDays { get; set; }

    public int? StlDefaultHours { get; set; }

    public int? StlLoanQty { get; set; }

    public string? StlAllowRenew { get; set; }

    public int? StlTimesRenew { get; set; }
}
