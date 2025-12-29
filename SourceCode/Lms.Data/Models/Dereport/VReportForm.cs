using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VReportForm
{
    public int AReportForm { get; set; }

    public string? Dbname { get; set; }

    public string AReportFormName { get; set; } = null!;

    public string AReportFormDesc { get; set; } = null!;
}
