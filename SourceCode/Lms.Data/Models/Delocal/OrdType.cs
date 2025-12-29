using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OrdType
{
    public string OtCode { get; set; } = null!;

    public string? OtDesc { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<OrdTypeTranslation> OrdTypeTranslations { get; set; } = new List<OrdTypeTranslation>();
}
