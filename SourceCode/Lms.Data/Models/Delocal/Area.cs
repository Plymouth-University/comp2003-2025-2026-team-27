using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Area
{
    public string? AreaName { get; set; }

    public string AreaCode { get; set; } = null!;

    public int? OrderId { get; set; }

    public virtual ICollection<AreaTranslation> AreaTranslations { get; set; } = new List<AreaTranslation>();
}
