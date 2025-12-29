using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ADrillField
{
    public long ADrillField1 { get; set; }

    public long ADrillDown { get; set; }

    public long DrillToParam { get; set; }

    public string ParentDataField { get; set; } = null!;

    public string? Operator { get; set; }
}
