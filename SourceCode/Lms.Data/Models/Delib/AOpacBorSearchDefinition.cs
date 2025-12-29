using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AOpacBorSearchDefinition
{
    public int SearchId { get; set; }

    public int SubSearchId { get; set; }

    public short QueryOptionType { get; set; }

    public string Keyword { get; set; } = null!;

    public string? TnWhere { get; set; }

    public string? KdCode { get; set; }

    public string? PreOperator { get; set; }

    public virtual AOpacBorSearch Search { get; set; } = null!;
}
