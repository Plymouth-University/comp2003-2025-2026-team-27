using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VStkItemCount
{
    public string? StkLocPerm { get; set; }

    public int? IsMissing { get; set; }

    public int? OnLoan { get; set; }

    public int? Reserved { get; set; }

    public int? OnOrder { get; set; }

    public int? Overdue { get; set; }
}
