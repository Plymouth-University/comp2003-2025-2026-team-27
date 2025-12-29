using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportForm
{
    public int AReportForm1 { get; set; }

    public short ADatabase { get; set; }

    public string AReportFormName { get; set; } = null!;

    public string AReportFormDesc { get; set; } = null!;

    public virtual ADatabase ADatabaseNavigation { get; set; } = null!;

    public virtual ICollection<AColumnAlias> AColumnAliases { get; set; } = new List<AColumnAlias>();
}
