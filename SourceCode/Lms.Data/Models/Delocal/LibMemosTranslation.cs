using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibMemosTranslation
{
    public int Lcid { get; set; }

    public string LmType { get; set; } = null!;

    public string? LmDesc { get; set; }

    public string LlGroup { get; set; } = null!;

    public virtual LibMemo LibMemo { get; set; } = null!;
}
