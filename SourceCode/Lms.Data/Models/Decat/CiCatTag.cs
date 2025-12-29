using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CiCatTag
{
    public string? TagMarc { get; set; }

    public DateTime? TagDatetime { get; set; }

    public string? TagOper { get; set; }

    public int? TagUniqueNo { get; set; }

    public int? TagNo { get; set; }

    public int? TagtempInd1 { get; set; }

    public int? TagtempInd2 { get; set; }

    public string? TagInd1 { get; set; }

    public string? TagInd2 { get; set; }

    public string? TagLibGroup { get; set; }

    public decimal? TagSecurity { get; set; }
}
