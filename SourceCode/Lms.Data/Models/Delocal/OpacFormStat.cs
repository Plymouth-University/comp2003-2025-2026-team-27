using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacFormStat
{
    public string OfsForm { get; set; } = null!;

    public string OfsStatsCode { get; set; } = null!;

    public string? OfsDescription { get; set; }

    public virtual ICollection<OpacFormStatsTranslation> OpacFormStatsTranslations { get; set; } = new List<OpacFormStatsTranslation>();
}
