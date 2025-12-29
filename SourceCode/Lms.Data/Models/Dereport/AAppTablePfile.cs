using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AAppTablePfile
{
    public string AAppTable { get; set; } = null!;

    public int AApplication { get; set; }

    public int AProfile { get; set; }

    public int? AAuthority { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public int? Priority { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public virtual AAppTable AAppTableNavigation { get; set; } = null!;

    public virtual AAuthority? AAuthorityNavigation { get; set; }

    public virtual AProfile AProfileNavigation { get; set; } = null!;
}
