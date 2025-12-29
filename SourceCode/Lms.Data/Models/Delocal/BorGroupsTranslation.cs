using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorGroupsTranslation
{
    public string BgGroup { get; set; } = null!;

    public int Lcid { get; set; }

    public string? BgName { get; set; }

    public virtual BorGroup BgGroupNavigation { get; set; } = null!;
}
