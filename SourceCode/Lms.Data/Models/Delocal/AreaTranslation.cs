using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AreaTranslation
{
    public string AreaCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? AreaName { get; set; }

    public virtual Area AreaCodeNavigation { get; set; } = null!;
}
