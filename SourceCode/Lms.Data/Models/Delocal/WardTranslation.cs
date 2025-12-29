using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class WardTranslation
{
    public string WardCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? WardName { get; set; }

    public virtual Ward WardCodeNavigation { get; set; } = null!;
}
