using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class PerCode
{
    public string PcCode { get; set; } = null!;

    public string? PcDesc { get; set; }

    public string? PcUnit { get; set; }

    public decimal? PcUnitLength { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<PerCodesTranslation> PerCodesTranslations { get; set; } = new List<PerCodesTranslation>();
}
