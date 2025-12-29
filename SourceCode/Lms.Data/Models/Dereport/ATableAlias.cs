using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ATableAlias
{
    public short ADatabase { get; set; }

    public string TableName { get; set; } = null!;

    public string TableAlias { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<AColumnAlias> AColumnAliases { get; set; } = new List<AColumnAlias>();

    public virtual ADatabase ADatabaseNavigation { get; set; } = null!;

    public virtual ICollection<AReportJoin> AReportJoinATableAliasNavigations { get; set; } = new List<AReportJoin>();

    public virtual ICollection<AReportJoin> AReportJoinATableAliases { get; set; } = new List<AReportJoin>();

    public virtual ICollection<AReportTableAlias> AReportTableAliases { get; set; } = new List<AReportTableAlias>();
}
