using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CashTill
{
    public int Id { get; set; }

    public string? TillNo { get; set; }

    public string? TillName { get; set; }

    public string? LlCode { get; set; }

    public string? IsActive { get; set; }

    public string? Operator { get; set; }
}
