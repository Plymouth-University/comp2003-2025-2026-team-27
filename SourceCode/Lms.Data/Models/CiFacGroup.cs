using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CiFacGroup
{
    public int? FgNo { get; set; }

    public string? FgDesc { get; set; }

    public string? FgKey { get; set; }

    public string? FgComments { get; set; }

    public int? FgCatNo { get; set; }

    public int? FgFacCount { get; set; }
}
