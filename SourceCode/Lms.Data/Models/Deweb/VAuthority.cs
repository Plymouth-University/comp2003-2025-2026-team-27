using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAuthority
{
    public int? AuthNo { get; set; }

    public string? AuthMarc { get; set; }

    public int? AuthTagNo { get; set; }

    public int? AuthSee { get; set; }

    public string? AuthHasSa { get; set; }

    public int? AuthKeepNo { get; set; }

    public string? AuthKey { get; set; }

    public string? AuthOper { get; set; }

    public string? AuthSoundex { get; set; }

    public DateTime? AuthDatetime { get; set; }

    public string? AuthInd1 { get; set; }

    public string? AuthInd2 { get; set; }

    public int? AuthtempInd1 { get; set; }

    public int? AuthtempInd2 { get; set; }

    public string? AuthNote { get; set; }

    public string? AuthLibGroup { get; set; }

    public decimal? AuthSecurity { get; set; }
}
