using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Z3950GroupTranslation
{
    public int ZgUniqueNo { get; set; }

    public int Lcid { get; set; }

    public string? ZgDescription { get; set; }

    public virtual Z3950Group ZgUniqueNoNavigation { get; set; } = null!;
}
