using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorClassesTranslation
{
    public string BcClass { get; set; } = null!;

    public int Lcid { get; set; }

    public string? BcName { get; set; }

    public virtual BorClass BcClassNavigation { get; set; } = null!;
}
