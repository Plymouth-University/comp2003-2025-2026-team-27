using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LocMap
{
    public string? LocCode { get; set; }

    public string? LocMapCode { get; set; }

    public string? LocMapDesc { get; set; }

    public int? LocMapX { get; set; }

    public int? LocMapY { get; set; }

    public string? LocMapFile { get; set; }
}
