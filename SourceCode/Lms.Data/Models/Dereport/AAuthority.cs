using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AAuthority
{
    public int AAuthority1 { get; set; }

    public string? Description { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public virtual ICollection<AAppTablePfile> AAppTablePfiles { get; set; } = new List<AAppTablePfile>();
}
