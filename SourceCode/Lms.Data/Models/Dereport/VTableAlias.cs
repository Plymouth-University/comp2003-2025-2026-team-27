using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VTableAlias
{
    public string? Dbname { get; set; }

    public string TableName { get; set; } = null!;

    public string TableAlias { get; set; } = null!;

    public string? Description { get; set; }
}
