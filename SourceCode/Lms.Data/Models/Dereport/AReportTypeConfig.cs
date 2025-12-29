using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportTypeConfig
{
    public long AReportTypeId { get; set; }

    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;
}
