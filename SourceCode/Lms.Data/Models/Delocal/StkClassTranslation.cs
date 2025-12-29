using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkClassTranslation
{
    public string Code { get; set; } = null!;

    public int Lcid { get; set; }

    public string? ClassDesc { get; set; }
}
