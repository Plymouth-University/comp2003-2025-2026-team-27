using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkItemOrigin
{
    public string StoItemOrigin { get; set; } = null!;

    public string? StoOriginDesc { get; set; }

    public string? StoAllowDepr { get; set; }

    public string? StoRoundUp { get; set; }

    public string? StoRoundDown { get; set; }

    public decimal? StoNearestDoll { get; set; }

    public string? StoKeepDeprHist { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<StkItemOriginsTranslation> StkItemOriginsTranslations { get; set; } = new List<StkItemOriginsTranslation>();
}
