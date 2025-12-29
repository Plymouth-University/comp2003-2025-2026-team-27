using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibGroup
{
    public string LgGroup { get; set; } = null!;

    public string? LgReturnHere { get; set; }

    public string? LgAllowNgreturn { get; set; }

    public string? LgMsgGreturn { get; set; }

    public string? LgPosition { get; set; }

    public string? LgRule { get; set; }

    public string? LgLevel1 { get; set; }

    public string? LgLevel2 { get; set; }

    public string? LgLevel3 { get; set; }

    public string? LgLevel4 { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<LibGroupsTranslation> LibGroupsTranslations { get; set; } = new List<LibGroupsTranslation>();
}
