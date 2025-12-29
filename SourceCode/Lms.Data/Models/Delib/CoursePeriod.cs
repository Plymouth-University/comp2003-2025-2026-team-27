using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CoursePeriod
{
    public string CpCoCode { get; set; } = null!;

    public DateTime CpDateFrom { get; set; }

    public DateTime CpDateTo { get; set; }
}
