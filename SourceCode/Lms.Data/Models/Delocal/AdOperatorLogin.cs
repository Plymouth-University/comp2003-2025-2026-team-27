using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AdOperatorLogin
{
    public int AuditId { get; set; }

    public string? LoginSite { get; set; }

    public string? LoginUsername { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? LoginStatus { get; set; }
}
