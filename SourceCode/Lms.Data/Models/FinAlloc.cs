using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinAlloc
{
    public string FaCode { get; set; } = null!;

    public string? FaDesc { get; set; }

    public string FaLibGroup { get; set; } = null!;

    public int? OrderId { get; set; }

    public virtual ICollection<FinAllocTranslation> FinAllocTranslations { get; set; } = new List<FinAllocTranslation>();
}
