using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ASchedulerUtility
{
    public int SchedulerId { get; set; }

    public int UtilityId { get; set; }

    public string? Status { get; set; }

    public string? OutputFilename { get; set; }
}
