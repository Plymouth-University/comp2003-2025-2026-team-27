using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VBorCoursePeriod
{
    public int BorNo { get; set; }

    public string BorCoCode { get; set; } = null!;

    public DateTime BorCpDateFrom { get; set; }

    public DateTime BorCpDateTo { get; set; }

    public string? CoDescription { get; set; }
}
