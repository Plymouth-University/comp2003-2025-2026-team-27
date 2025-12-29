using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class FinAlloc
{
    public string FaCode { get; set; } = null!;

    public string? FaDesc { get; set; }

    public string FaLibGroup { get; set; } = null!;

    public virtual ICollection<FinAllocTranslation> FinAllocTranslations { get; set; } = new List<FinAllocTranslation>();
}
