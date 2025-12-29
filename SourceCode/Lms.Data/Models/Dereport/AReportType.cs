using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportType
{
    public short AReportTypeId { get; set; }

    public int AReport { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateTime { get; set; }

    public short? CreateReadyFile { get; set; }

    public virtual AReport AReportNavigation { get; set; } = null!;

    public virtual AReportTypeLookup AReportTypeNavigation { get; set; } = null!;
}
