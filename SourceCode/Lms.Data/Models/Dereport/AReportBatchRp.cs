using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportBatchRp
{
    public int AReportBatch { get; set; }

    public int AReport { get; set; }

    public string? OutputFilename { get; set; }

    public short BatchSeqNo { get; set; }

    public virtual AReportBatch AReportBatchNavigation { get; set; } = null!;

    public virtual AReport AReportNavigation { get; set; } = null!;
}
