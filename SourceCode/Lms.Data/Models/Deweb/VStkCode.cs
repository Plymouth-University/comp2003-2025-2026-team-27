using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VStkCode
{
    public string? StkCodeDesc { get; set; }

    public string? StkGroup { get; set; }

    public string StkCode { get; set; } = null!;

    public string? StkAllowLoan { get; set; }

    public string? StkFloating { get; set; }

    public string? StkJournalSearchShowyn { get; set; }

    public int? OrderId { get; set; }
}
