using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AOpacBorSearchAuthOrNonauth
{
    public int SearchId { get; set; }

    public int SubSearchId { get; set; }

    public bool Isauth { get; set; }

    public string Keyword { get; set; } = null!;

    public string? TnWhere { get; set; }

    public string? KdCode { get; set; }

    public string? PreOperator { get; set; }
}
