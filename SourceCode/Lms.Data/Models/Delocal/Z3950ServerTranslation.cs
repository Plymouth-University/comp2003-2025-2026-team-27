using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Z3950ServerTranslation
{
    public int ZsUniqueNo { get; set; }

    public int Lcid { get; set; }

    public string? ZsDescription { get; set; }

    public virtual Z3950Server ZsUniqueNoNavigation { get; set; } = null!;
}
