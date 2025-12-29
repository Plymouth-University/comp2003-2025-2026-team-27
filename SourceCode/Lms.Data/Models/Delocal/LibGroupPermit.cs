using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibGroupPermit
{
    public string? LgpGivefromGroup { get; set; }

    public string? LgpTable { get; set; }

    public string? LgpAction { get; set; }

    public string? LgpGivetoGroup { get; set; }
}
