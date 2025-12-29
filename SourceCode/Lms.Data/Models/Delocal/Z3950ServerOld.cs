using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Z3950ServerOld
{
    public int? ZsUniqueNo { get; set; }

    public string? ZsDescription { get; set; }

    public int? ZsSequence { get; set; }

    public string? ZsType { get; set; }

    public string? ZsHost { get; set; }

    public int? ZsPort { get; set; }

    public string? ZsDatabase { get; set; }

    public string? ZsUserId { get; set; }

    public string? ZsPassword { get; set; }

    public string? ZsAllowScan { get; set; }

    public string? ZsAllowImport { get; set; }

    public string? ZsDisplay { get; set; }

    public int? ZsTimeout { get; set; }

    public int? ZsMaximumSize { get; set; }

    public int? ZsPreferredSize { get; set; }

    public int? ZsInitialFetch { get; set; }

    public int? ZsMaximumFetch { get; set; }

    public string? ZsAllowHoldings { get; set; }
}
