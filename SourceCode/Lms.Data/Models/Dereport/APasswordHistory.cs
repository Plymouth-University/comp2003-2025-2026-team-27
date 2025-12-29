using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class APasswordHistory
{
    public int APasswordHistory1 { get; set; }

    public int AAnsUser { get; set; }

    public string? UserName { get; set; }

    public string? APassword { get; set; }

    public DateTime? ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string? Deleted { get; set; }

    public virtual AAnsUser AAnsUserNavigation { get; set; } = null!;
}
