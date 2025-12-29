using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VLibMemo
{
    public string LmType { get; set; } = null!;

    public string? LmDesc { get; set; }

    public string? LmValidStk { get; set; }

    public string? LmValidBor { get; set; }

    public string? LmShow { get; set; }

    public int? LmDays { get; set; }

    public string? LmShowonreturn { get; set; }

    public string LlGroup { get; set; } = null!;
}
