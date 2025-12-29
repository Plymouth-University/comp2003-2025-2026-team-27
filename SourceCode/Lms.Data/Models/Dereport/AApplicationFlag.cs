using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AApplicationFlag
{
    public int AApplicationFlag1 { get; set; }

    public int ApplicationFlag { get; set; }

    public int AApplication { get; set; }

    public string? Description { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public int? ValueDefault { get; set; }

    public int? AQbuildForm { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public virtual ICollection<AAppFlagValue> AAppFlagValues { get; set; } = new List<AAppFlagValue>();

    public virtual AApplication AApplicationNavigation { get; set; } = null!;

    public virtual ICollection<AProfileFlag> AProfileFlags { get; set; } = new List<AProfileFlag>();

    public virtual AQbuildForm? AQbuildFormNavigation { get; set; }
}
