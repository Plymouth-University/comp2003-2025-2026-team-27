using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class PredefinedQueryOption
{
    public int PqoId { get; set; }

    public int PqoType { get; set; }

    public string PqoDesc { get; set; } = null!;

    public string? PqoCondition { get; set; }

    public int? PqoStatsType { get; set; }

    public string PqoOpacHomeSearch { get; set; } = null!;

    public string PqoOpacShow { get; set; } = null!;

    public virtual ICollection<PredefinedQueryOptionTranslation> PredefinedQueryOptionTranslations { get; set; } = new List<PredefinedQueryOptionTranslation>();
}
