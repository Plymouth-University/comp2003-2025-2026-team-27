using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OrdConditionTranslation
{
    public int Lcid { get; set; }

    public string OcCode { get; set; } = null!;

    public string? OcDesc { get; set; }

    public virtual OrdCondition OcCodeNavigation { get; set; } = null!;
}
