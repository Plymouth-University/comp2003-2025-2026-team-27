using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorCoursePeriod
{
    public int BorNo { get; set; }

    public string BorCoCode { get; set; } = null!;

    public DateTime BorCpDateFrom { get; set; }

    public DateTime BorCpDateTo { get; set; }
}
