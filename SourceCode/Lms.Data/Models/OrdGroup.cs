using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class OrdGroup
{
    public string? OgGroupNo { get; set; }

    public string? OgSummary { get; set; }

    public string? OgKey { get; set; }

    public string? OgDescription { get; set; }

    public string? OgOper { get; set; }

    public DateTime? OgDatetime { get; set; }
}
