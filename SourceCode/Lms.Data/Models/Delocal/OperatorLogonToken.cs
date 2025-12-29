using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OperatorLogonToken
{
    public string OperName { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime? CreateDatetime { get; set; }

    public DateTime? LastUpdated { get; set; }

    public DateTime? IssuedOn { get; set; }

    public DateTime? ExpiresOn { get; set; }
}
