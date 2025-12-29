using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CashTillOperator
{
    public int? TillId { get; set; }

    public string? IsActive { get; set; }

    public string? Operator { get; set; }
}
