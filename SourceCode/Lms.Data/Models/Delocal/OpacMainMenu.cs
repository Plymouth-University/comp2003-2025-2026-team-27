using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacMainMenu
{
    public int? OpacFunction { get; set; }

    public string? OpacTitle { get; set; }

    public string? OpacDesc { get; set; }

    public int? OpacBgColour { get; set; }

    public int? OpacFgColour { get; set; }
}
