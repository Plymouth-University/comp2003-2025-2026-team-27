using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ward
{
    public string? WardName { get; set; }

    public string WardCode { get; set; } = null!;

    public int? OrderId { get; set; }

    public virtual ICollection<WardTranslation> WardTranslations { get; set; } = new List<WardTranslation>();
}
