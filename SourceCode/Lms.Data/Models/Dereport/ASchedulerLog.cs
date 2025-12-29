using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ASchedulerLog
{
    public int ASchedulerLogId { get; set; }

    public int ASchedulerId { get; set; }

    public DateTime EventDatetime { get; set; }

    public string LogDescription { get; set; } = null!;

    public string LogResultStatus { get; set; } = null!;

    public virtual AScheduler AScheduler { get; set; } = null!;
}
