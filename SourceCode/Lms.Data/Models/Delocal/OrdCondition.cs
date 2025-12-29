using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OrdCondition
{
    public string OcCode { get; set; } = null!;

    public string? OcDesc { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<OrdConditionTranslation> OrdConditionTranslations { get; set; } = new List<OrdConditionTranslation>();
}
