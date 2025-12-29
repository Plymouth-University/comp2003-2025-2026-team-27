using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class SuburbTranslation
{
    public string SuburbCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? SuburbName { get; set; }

    public virtual Suburb SuburbCodeNavigation { get; set; } = null!;
}
