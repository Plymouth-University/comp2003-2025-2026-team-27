using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AReportFav
{
    public int AReportFavs { get; set; }

    public string? Description { get; set; }

    public int? AReport { get; set; }

    public int? AReportGroup { get; set; }

    public string? ReportDesc { get; set; }

    public string? GroupDesc { get; set; }

    public string? Username { get; set; }

    public byte[]? Params { get; set; }
}
