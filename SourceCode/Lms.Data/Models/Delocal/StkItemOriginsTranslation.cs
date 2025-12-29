using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkItemOriginsTranslation
{
    public string StoItemOrigin { get; set; } = null!;

    public int Lcid { get; set; }

    public string? StoOriginDesc { get; set; }

    public virtual StkItemOrigin StoItemOriginNavigation { get; set; } = null!;
}
