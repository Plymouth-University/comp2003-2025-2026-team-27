using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkCodesTranslation
{
    public string StkCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? StkCodeDesc { get; set; }

    public virtual StkCode StkCodeNavigation { get; set; } = null!;
}
