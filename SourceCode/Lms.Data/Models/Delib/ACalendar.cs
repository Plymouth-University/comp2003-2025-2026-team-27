using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ACalendar
{
    public DateOnly? TheDate { get; set; }

    public int? Day { get; set; }

    public string? TheDayName { get; set; }

    public bool? IsWeekend { get; set; }
}
