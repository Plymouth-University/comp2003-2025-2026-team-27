using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class FinAllocTranslation
{
    public int Lcid { get; set; }

    public string FaLibGroup { get; set; } = null!;

    public string FaCode { get; set; } = null!;

    public string? FaDesc { get; set; }

    public virtual FinAlloc FinAlloc { get; set; } = null!;
}
