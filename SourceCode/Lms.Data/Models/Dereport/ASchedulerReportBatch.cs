using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ASchedulerReportBatch
{
    public int SchedulerId { get; set; }

    public int AReportBatch { get; set; }

    public short AReportTypeId { get; set; }

    public string? Status { get; set; }

    public virtual AReportBatch AReportBatchNavigation { get; set; } = null!;

    public virtual AReportTypeLookup AReportType { get; set; } = null!;

    public virtual AScheduler Scheduler { get; set; } = null!;
}
