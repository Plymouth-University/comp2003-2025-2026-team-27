using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacTagdefTranslation
{
    public int Lcid { get; set; }

    public int TtTagno { get; set; }

    public string? TtTagdesc { get; set; }

    public virtual OpacTagdef TtTagnoNavigation { get; set; } = null!;
}
