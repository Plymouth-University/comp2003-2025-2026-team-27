using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthSeeAlso
{
    public int? AuthNo { get; set; }

    public int? AuthSeeAlso1 { get; set; }

    public string? AuthSaTerm { get; set; }

    public string? AuthOper { get; set; }

    public DateTime? AuthDatetime { get; set; }
}
