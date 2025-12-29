using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Z3950Attr
{
    public int ZaUniqueNo { get; set; }

    public string? ZaDescription { get; set; }

    public string? ZaType { get; set; }

    public int? ZaSequence { get; set; }

    public int? ZaAttr1 { get; set; }

    public int? ZaAttr2 { get; set; }

    public int? ZaAttr3 { get; set; }

    public int? ZaAttr4 { get; set; }

    public int? ZaAttr5 { get; set; }

    public int? ZaAttr6 { get; set; }

    public virtual ICollection<Z3950AttrTranslation> Z3950AttrTranslations { get; set; } = new List<Z3950AttrTranslation>();
}
