using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorClass
{
    public string BcClass { get; set; } = null!;

    public string? BcName { get; set; }

    public int? OrderId { get; set; }

    public int? ClassTypeId { get; set; }

    public virtual ICollection<BorClassesTranslation> BorClassesTranslations { get; set; } = new List<BorClassesTranslation>();
}
