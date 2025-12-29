using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagTagdefTranslation
{
    public int TtTagno { get; set; }

    public int Lcid { get; set; }

    public string? TtTagdesc { get; set; }

    public virtual TagTagdef TtTagnoNavigation { get; set; } = null!;
}
