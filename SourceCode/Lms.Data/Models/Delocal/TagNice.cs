using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagNice
{
    public int? TnTagno { get; set; }

    public string? TnDesc { get; set; }

    public string? TnWhere { get; set; }

    public string? TnStoplist { get; set; }

    public int? StatsType { get; set; }

    public int? OrderId { get; set; }
}
