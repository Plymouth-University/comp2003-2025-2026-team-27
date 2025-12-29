using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkIllStatusTranslation
{
    public int SisCode { get; set; }

    public int Lcid { get; set; }

    public string? SisDescription { get; set; }

    public virtual StkIllStatus SisCodeNavigation { get; set; } = null!;
}
