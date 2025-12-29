using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkStatsGroup
{
    public string StkGroup { get; set; } = null!;

    public string? StkGroupDesc { get; set; }

    public string? StkDeprAccount { get; set; }

    public virtual ICollection<StkStatsGroupTranslation> StkStatsGroupTranslations { get; set; } = new List<StkStatsGroupTranslation>();
}
