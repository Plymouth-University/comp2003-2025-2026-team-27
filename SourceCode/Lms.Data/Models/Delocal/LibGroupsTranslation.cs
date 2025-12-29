using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibGroupsTranslation
{
    public int Lcid { get; set; }

    public string LgGroup { get; set; } = null!;

    public string? LgGroupTran { get; set; }

    public virtual LibGroup LgGroupNavigation { get; set; } = null!;
}
