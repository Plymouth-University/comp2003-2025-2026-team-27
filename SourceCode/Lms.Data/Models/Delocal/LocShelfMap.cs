using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LocShelfMap
{
    public string? LocSmCode { get; set; }

    public string? LocSmMapCode { get; set; }

    public string? LocSmCallFrom { get; set; }

    public string? LocSmCallTo { get; set; }

    public int? LocSmMapXstart { get; set; }

    public int? LocSmMapXend { get; set; }

    public int? LocSmMapYstart { get; set; }

    public int? LocSmMapYend { get; set; }
}
