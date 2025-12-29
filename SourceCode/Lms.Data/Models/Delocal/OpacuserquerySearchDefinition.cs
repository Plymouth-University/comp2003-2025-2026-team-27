using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacuserquerySearchDefinition
{
    public string OuqLocation { get; set; } = null!;

    public string OuqType { get; set; } = null!;

    public DateTime OuqDate { get; set; }

    public int SubSearchId { get; set; }

    public short QueryOptionType { get; set; }

    public string Keyword { get; set; } = null!;

    public string? TnWhere { get; set; }

    public string? KdCode { get; set; }

    public string? PreOperator { get; set; }
}
