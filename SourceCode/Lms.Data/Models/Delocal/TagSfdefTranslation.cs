using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagSfdefTranslation
{
    public int TsTagno { get; set; }

    public string TsSf { get; set; } = null!;

    public int Lcid { get; set; }

    public string? TsSfDesc { get; set; }

    public virtual TagSfdef TagSfdef { get; set; } = null!;
}
