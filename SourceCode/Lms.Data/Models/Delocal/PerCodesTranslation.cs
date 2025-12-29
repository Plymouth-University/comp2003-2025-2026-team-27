using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class PerCodesTranslation
{
    public int Lcid { get; set; }

    public string PcCode { get; set; } = null!;

    public string? PcDesc { get; set; }

    public virtual PerCode PcCodeNavigation { get; set; } = null!;
}
