using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacLibGroupsStyle
{
    public string LgGroup { get; set; } = null!;

    public string? OpacDisplayGroup { get; set; }

    public string? MainColor { get; set; }

    public bool? OwnLogo { get; set; }

    public bool? OwnDefaultBookImages { get; set; }

    public bool? OpacShow { get; set; }

    public string? ChartColorCode { get; set; }
}
