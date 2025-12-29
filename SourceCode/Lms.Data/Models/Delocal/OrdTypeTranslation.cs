using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OrdTypeTranslation
{
    public int Lcid { get; set; }

    public string OtCode { get; set; } = null!;

    public string? OtDesc { get; set; }

    public virtual OrdType OtCodeNavigation { get; set; } = null!;
}
