using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AProfileFlag
{
    public int AProfile { get; set; }

    public int AApplicationFlag { get; set; }

    public int ApplicationFlag { get; set; }

    public int AApplication { get; set; }

    public int AAppFlagValue { get; set; }

    public int AppFlagValue { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateTime { get; set; }

    public int? AQbuildForm { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public virtual AApplicationFlag AApplicationFlagNavigation { get; set; } = null!;

    public virtual AProfile AProfileNavigation { get; set; } = null!;
}
