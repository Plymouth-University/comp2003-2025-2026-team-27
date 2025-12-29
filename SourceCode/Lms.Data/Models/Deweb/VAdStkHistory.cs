using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAdStkHistory
{
    public DateTime? ShDate { get; set; }

    public string? ShBorNo { get; set; }

    public string? ShStkItemNo { get; set; }

    public string? ShComments { get; set; }

    public int? ShResNo { get; set; }

    public string? ShType { get; set; }

    public decimal? ShValue { get; set; }
}
