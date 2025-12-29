using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Z3950AttrTranslation
{
    public int ZaUniqueNo { get; set; }

    public int Lcid { get; set; }

    public string? ZaDescription { get; set; }

    public virtual Z3950Attr ZaUniqueNoNavigation { get; set; } = null!;
}
