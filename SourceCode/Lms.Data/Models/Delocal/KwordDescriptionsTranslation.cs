using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class KwordDescriptionsTranslation
{
    public string KdCode { get; set; } = null!;

    public string? KdDesc { get; set; }

    public int Lcid { get; set; }

    public virtual KwordDescription KdCodeNavigation { get; set; } = null!;
}
