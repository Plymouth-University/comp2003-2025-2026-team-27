using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkCallSetsTranslation
{
    public int Lcid { get; set; }

    public int ScLineNo { get; set; }

    public string? ScCodeRef { get; set; }

    public string? ScDesc { get; set; }

    public virtual StkCallSet ScLineNoNavigation { get; set; } = null!;
}
