using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ReportControl
{
    public int? RcRepNumber { get; set; }

    public int? RcFieldNumber { get; set; }

    public int? RcRepPrintNo { get; set; }

    public string? RcParam1 { get; set; }

    public string? RcParam2 { get; set; }

    public string? RcParam3 { get; set; }

    public string? RcParam4 { get; set; }

    public int? RcOrigRepNo { get; set; }
}
