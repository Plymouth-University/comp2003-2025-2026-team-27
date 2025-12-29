using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ASchedulerReportType
{
    public int SchedulerId { get; set; }

    public int AReport { get; set; }

    public short AReportTypeId { get; set; }

    public virtual AReport AReportNavigation { get; set; } = null!;

    public virtual AReportTypeLookup AReportType { get; set; } = null!;

    public virtual ASchedulerReport ASchedulerReport { get; set; } = null!;
}
