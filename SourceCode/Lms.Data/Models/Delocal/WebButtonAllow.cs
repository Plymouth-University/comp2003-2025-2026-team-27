using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class WebButtonAllow
{
    public string? WbaApp { get; set; }

    public int? WbaScreenNumber { get; set; }

    public int? WbaButtonNo { get; set; }

    public string? WbaUserName { get; set; }

    public string? WbaAllowUse { get; set; }
}
