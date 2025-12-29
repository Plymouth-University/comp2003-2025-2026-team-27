using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AProfile
{
    public int AProfile1 { get; set; }

    public string? Description { get; set; }

    public string? UserName { get; set; }

    public string? ProfilePassword { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LocalId { get; set; }

    public int DataAccessLevel { get; set; }

    public int? DeleteFlag { get; set; }

    public virtual ICollection<AAppTablePfile> AAppTablePfiles { get; set; } = new List<AAppTablePfile>();

    public virtual ICollection<AClientReport> AClientReports { get; set; } = new List<AClientReport>();

    public virtual ICollection<AProfileFlag> AProfileFlags { get; set; } = new List<AProfileFlag>();

    public virtual ICollection<AProfileUser> AProfileUsers { get; set; } = new List<AProfileUser>();
}
