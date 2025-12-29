using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagCatNice
{
    public string? TnDesc { get; set; }

    public int? TnTagno { get; set; }

    public string? TnWhere { get; set; }

    public string? TnStoplist { get; set; }

    public int? StatsType { get; set; }

    public string? OpacShow { get; set; }

    public string? OpacHomeSearch { get; set; }

    public byte TnAuthoritySearch { get; set; }
}
