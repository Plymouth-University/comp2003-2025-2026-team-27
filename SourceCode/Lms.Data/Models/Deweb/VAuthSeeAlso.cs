using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAuthSeeAlso
{
    public int? AuthNo { get; set; }

    public int? AuthSeeAlso { get; set; }

    public string? AuthSaTerm { get; set; }

    public string? AuthOper { get; set; }

    public DateTime? AuthDatetime { get; set; }
}
