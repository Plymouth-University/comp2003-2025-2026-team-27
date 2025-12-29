using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorGroup
{
    public string BgGroup { get; set; } = null!;

    public string? BgName { get; set; }

    public int? OrderId { get; set; }

    public int? GroupTypeId { get; set; }

    public virtual ICollection<BorGroupsTranslation> BorGroupsTranslations { get; set; } = new List<BorGroupsTranslation>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
