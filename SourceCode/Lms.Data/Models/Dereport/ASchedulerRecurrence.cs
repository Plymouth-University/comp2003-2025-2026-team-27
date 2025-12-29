using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ASchedulerRecurrence
{
    public int SchedulerId { get; set; }

    public int? Frecuency { get; set; }

    public int? DayNo { get; set; }

    public int? Interval { get; set; }

    public int? WeekOfMonth { get; set; }

    public bool? Monday { get; set; }

    public bool? Tuesday { get; set; }

    public bool? Wednesday { get; set; }

    public bool? Thursday { get; set; }

    public bool? Friday { get; set; }

    public bool? Saturday { get; set; }

    public bool? Sunday { get; set; }

    public bool? January { get; set; }

    public bool? February { get; set; }

    public bool? March { get; set; }

    public bool? April { get; set; }

    public bool? May { get; set; }

    public bool? June { get; set; }

    public bool? July { get; set; }

    public bool? August { get; set; }

    public bool? September { get; set; }

    public bool? October { get; set; }

    public bool? November { get; set; }

    public bool? December { get; set; }

    public bool? RepeatFlag { get; set; }

    public int? RepeatUnit { get; set; }

    public int? RepeatInterval { get; set; }

    public int? RepeatUnitDuration { get; set; }

    public int? RepeatDuration { get; set; }

    public virtual AScheduler Scheduler { get; set; } = null!;
}
