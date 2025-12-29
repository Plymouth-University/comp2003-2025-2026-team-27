using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorStatusTranslation
{
    public string BsType { get; set; } = null!;

    public int Lcid { get; set; }

    public string? BsName { get; set; }

    public virtual BorStatus BsTypeNavigation { get; set; } = null!;
}
