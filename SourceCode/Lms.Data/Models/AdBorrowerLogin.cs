using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AdBorrowerLogin
{
    public int AuditId { get; set; }

    public string? LoginSite { get; set; }

    public string? LoginBorbarcode { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? LoginStatus { get; set; }
}
