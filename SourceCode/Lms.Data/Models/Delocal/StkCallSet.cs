using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkCallSet
{
    public int ScLineNo { get; set; }

    public string? ScCodeRef { get; set; }

    public string? ScCallFrom { get; set; }

    public string? ScCallTo { get; set; }

    public string? ScDesc { get; set; }

    public virtual ICollection<StkCallSetsTranslation> StkCallSetsTranslations { get; set; } = new List<StkCallSetsTranslation>();
}
