using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class KwordDescription
{
    public string KdCode { get; set; } = null!;

    public string? KdDesc { get; set; }

    public int? StatsType { get; set; }

    public string? OpacShow { get; set; }

    public string? OpacHomeSearch { get; set; }

    public string? KdStoplist { get; set; }

    public virtual ICollection<KwordDescriptionsTranslation> KwordDescriptionsTranslations { get; set; } = new List<KwordDescriptionsTranslation>();
}
