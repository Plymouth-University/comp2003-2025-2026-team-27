using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkStatsGroupTranslation
{
    public string StkGroup { get; set; } = null!;

    public int Lcid { get; set; }

    public string? StkGroupDesc { get; set; }

    public virtual StkStatsGroup StkGroupNavigation { get; set; } = null!;
}
