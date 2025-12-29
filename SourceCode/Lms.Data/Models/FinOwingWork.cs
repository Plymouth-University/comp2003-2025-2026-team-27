using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinOwingWork
{
    public string? WBorBarNo { get; set; }

    public decimal? WOwing { get; set; }

    public int? WLoanCount { get; set; }

    public string? WOper { get; set; }
}
