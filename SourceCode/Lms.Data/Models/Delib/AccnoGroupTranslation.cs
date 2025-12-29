using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AccnoGroupTranslation
{
    public int Lcid { get; set; }

    public string AccnoLibGroup { get; set; } = null!;

    public string AccnoCode { get; set; } = null!;

    public string? AccnoCodeDesc { get; set; }

    public virtual AccnoGroup AccnoGroup { get; set; } = null!;
}
