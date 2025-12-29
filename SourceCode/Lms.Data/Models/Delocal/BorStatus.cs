using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorStatus
{
    public string BsType { get; set; } = null!;

    public string? BsName { get; set; }

    public string? BsOverride { get; set; }

    public string? BsBanned { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<BorStatusTranslation> BorStatusTranslations { get; set; } = new List<BorStatusTranslation>();
}
