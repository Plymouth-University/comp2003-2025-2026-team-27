using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportSchPostStoreProc
{
    public int AReport { get; set; }

    public string PostStoredProc { get; set; } = null!;

    public int? Position { get; set; }

    public virtual AReport AReportNavigation { get; set; } = null!;
}
