using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ReportImportDatabaseMapping
{
    public Guid? ReportSessionId { get; set; }

    public string? Dbname { get; set; }

    public short? ADatabase { get; set; }
}
