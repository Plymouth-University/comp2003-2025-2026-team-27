using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportTypeLookup
{
    public short AReportTypeId { get; set; }

    public string? AReportType { get; set; }

    public short? ReadyFile { get; set; }

    public short? DeleteFlag { get; set; }

    public virtual ICollection<AReportType> AReportTypes { get; set; } = new List<AReportType>();

    public virtual ICollection<ASchedulerReportBatch> ASchedulerReportBatches { get; set; } = new List<ASchedulerReportBatch>();

    public virtual ICollection<ASchedulerReportType> ASchedulerReportTypes { get; set; } = new List<ASchedulerReportType>();
}
