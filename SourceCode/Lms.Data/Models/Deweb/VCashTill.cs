using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VCashTill
{
    public int Id { get; set; }

    public string? TillNo { get; set; }

    public string? TillName { get; set; }

    public string? LlCode { get; set; }

    public string? IsActive { get; set; }

    public string? Operator { get; set; }
}
