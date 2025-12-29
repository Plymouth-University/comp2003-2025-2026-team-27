using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AProfileUser
{
    public int AProfile { get; set; }

    public int AAnsUser { get; set; }

    public string? Role { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public virtual AAnsUser AAnsUserNavigation { get; set; } = null!;

    public virtual AProfile AProfileNavigation { get; set; } = null!;
}
