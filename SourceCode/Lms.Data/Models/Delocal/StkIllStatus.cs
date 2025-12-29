using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkIllStatus
{
    public int SisCode { get; set; }

    public string? SisDescription { get; set; }

    public virtual ICollection<StkIllStatusTranslation> StkIllStatusTranslations { get; set; } = new List<StkIllStatusTranslation>();
}
