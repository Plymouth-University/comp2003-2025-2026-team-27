using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacFormStatsTranslation
{
    public int Lcid { get; set; }

    public string OfsForm { get; set; } = null!;

    public string OfsStatsCode { get; set; } = null!;

    public string? OfsDescription { get; set; }

    public virtual OpacFormStat OpacFormStat { get; set; } = null!;
}
