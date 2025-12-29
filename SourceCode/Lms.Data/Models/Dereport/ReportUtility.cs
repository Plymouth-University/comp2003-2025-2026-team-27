using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ReportUtility
{
    public int UtilityId { get; set; }

    public string TaskUniqueName { get; set; } = null!;

    public string? TaskDescription { get; set; }

    public string? TaskPath { get; set; }
}
