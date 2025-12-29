using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkFormsTranslation
{
    public string StkForm { get; set; } = null!;

    public int Lcid { get; set; }

    public string? StkFormDesc { get; set; }

    public string? LlCode { get; set; }

    public string? LlGroup { get; set; }
}
