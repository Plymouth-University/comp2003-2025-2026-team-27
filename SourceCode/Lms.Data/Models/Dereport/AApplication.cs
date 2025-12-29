using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AApplication
{
    public int AApplication1 { get; set; }

    public string? ApplicationComment { get; set; }

    public string? Description { get; set; }

    public string? ApplicationName { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public string? AnsApplication { get; set; }

    public int? AQbuildApp { get; set; }

    public string? UseShadowLogin { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? Organisation { get; set; }

    public string? UseAdmin { get; set; }

    public short? DefPasswordDays { get; set; }

    public string? PasswordRules { get; set; }

    public virtual ICollection<AAppTable> AAppTables { get; set; } = new List<AAppTable>();

    public virtual ICollection<AApplicationFlag> AApplicationFlags { get; set; } = new List<AApplicationFlag>();
}
