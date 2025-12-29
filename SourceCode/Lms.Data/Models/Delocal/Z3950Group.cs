using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Z3950Group
{
    public int ZgUniqueNo { get; set; }

    public string? ZgDescription { get; set; }

    public int? ZgSequence { get; set; }

    public string? ZgType { get; set; }

    public virtual ICollection<Z3950GroupTranslation> Z3950GroupTranslations { get; set; } = new List<Z3950GroupTranslation>();
}
