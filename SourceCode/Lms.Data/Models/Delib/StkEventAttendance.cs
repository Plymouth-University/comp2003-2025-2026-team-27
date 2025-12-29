using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkEventAttendance
{
    public string StkItemNo { get; set; } = null!;

    public string BorBarNo { get; set; } = null!;

    public DateOnly DateOfEvent { get; set; }

    public int? Status { get; set; }

    public string? Anticipatedgrade { get; set; }

    public string? Notes { get; set; }
}
