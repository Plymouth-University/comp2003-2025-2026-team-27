using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ADatabase
{
    public short ADatabases { get; set; }

    public string? DatabaseName { get; set; }

    public string? DatabaseInitialCatalog { get; set; }

    public short AnsDbType { get; set; }

    public string Version { get; set; } = null!;

    public string? Patch { get; set; }

    public string? Description { get; set; }

    public string? DefaultUser { get; set; }

    public string? DefaultPassword { get; set; }

    public string? LastUpdatedBy { get; set; }

    public byte[] LastUpdatedOn { get; set; } = null!;

    public string? ExtendedProperties { get; set; }

    public virtual ICollection<AReportForm> AReportForms { get; set; } = new List<AReportForm>();

    public virtual ICollection<ATableAlias> ATableAliases { get; set; } = new List<ATableAlias>();
}
