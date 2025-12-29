using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorTypesTranslation
{
    public string BtType { get; set; } = null!;

    public int Lcid { get; set; }

    public string? BtName { get; set; }

    public virtual BorType BtTypeNavigation { get; set; } = null!;
}
