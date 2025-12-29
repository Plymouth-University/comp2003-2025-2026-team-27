using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VReportType
{
    public string? AReportType { get; set; }

    public int AReport { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateTime { get; set; }

    public short? CreateReadyFile { get; set; }
}
