using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StatsCodesTranslation
{
    public int Lcid { get; set; }

    public int StatsType { get; set; }

    public string? StatsDescription { get; set; }

    public virtual StatsCode StatsTypeNavigation { get; set; } = null!;
}
