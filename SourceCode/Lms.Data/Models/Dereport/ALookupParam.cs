using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ALookupParam
{
    public int ALookupParamId { get; set; }

    public short ADatabase { get; set; }

    public string ALookupParamName { get; set; } = null!;

    public string ALookupDefinition { get; set; } = null!;

    public bool DeleteFlag { get; set; }

    public virtual ICollection<AReportParam> AReportParams { get; set; } = new List<AReportParam>();
}
