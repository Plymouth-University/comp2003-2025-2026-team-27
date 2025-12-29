using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ASchedulerReport
{
    public int SchedulerId { get; set; }

    public int AReport { get; set; }

    public string? Status { get; set; }

    public string? OutputFilename { get; set; }

    public virtual ICollection<ASchedulerReportType> ASchedulerReportTypes { get; set; } = new List<ASchedulerReportType>();

    public virtual AScheduler Scheduler { get; set; } = null!;
}
