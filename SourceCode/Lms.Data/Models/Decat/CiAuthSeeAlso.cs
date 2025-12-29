using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CiAuthSeeAlso
{
    public int? AuthNo { get; set; }

    public int? AuthSeeAlso { get; set; }

    public string? AuthSaTerm { get; set; }

    public string? AuthOper { get; set; }

    public DateTime? AuthDatetime { get; set; }
}
