using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ADrillDown
{
    public long ADrillDown1 { get; set; }

    public long AReportParent { get; set; }

    public long AReportDrillTo { get; set; }
}
