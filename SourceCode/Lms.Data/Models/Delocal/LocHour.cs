using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LocHour
{
    public string? LhDay { get; set; }

    public int? LhOpenHour { get; set; }

    public int? LhOpenMinute { get; set; }

    public int? LhCloseHour { get; set; }

    public int? LhCloseMinute { get; set; }

    public string? LhLocation { get; set; }

    public int LocHoursId { get; set; }
}
