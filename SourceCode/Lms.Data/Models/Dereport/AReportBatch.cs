using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportBatch
{
    public int AReportBatch1 { get; set; }

    public string? BatchGrpName { get; set; }

    public string? Flag { get; set; }

    public bool? DeleteFlag { get; set; }

    public virtual ICollection<AReportBatchRp> AReportBatchRps { get; set; } = new List<AReportBatchRp>();

    public virtual ICollection<ASchedulerReportBatch> ASchedulerReportBatches { get; set; } = new List<ASchedulerReportBatch>();
}
