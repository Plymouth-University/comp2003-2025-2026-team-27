using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class WebButtonUser
{
    public string? WbuApp { get; set; }

    public int? WbuScreenNumber { get; set; }

    public int? WbuButtonNo { get; set; }

    public string? WbuUserName { get; set; }

    public string? WbuUserText { get; set; }
}
