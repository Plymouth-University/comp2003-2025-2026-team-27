using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AccnoGroup
{
    public string AccnoCode { get; set; } = null!;

    public string? AccnoCodeDesc { get; set; }

    public int? AccnoCodeLevel { get; set; }

    public int? AccnoStop { get; set; }

    public string AccnoLibGroup { get; set; } = null!;

    public virtual ICollection<AccnoGroupTranslation> AccnoGroupTranslations { get; set; } = new List<AccnoGroupTranslation>();
}
