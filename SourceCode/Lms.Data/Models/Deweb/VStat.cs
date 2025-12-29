using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VStat
{
    public int? StatsType { get; set; }

    public string? StatsLlCode { get; set; }

    public string? StatsBorType { get; set; }

    public string? StatsStkForm { get; set; }

    public int? StatsHour { get; set; }

    public int? StatsMonth { get; set; }

    public int? StatsYear { get; set; }

    public int? StatsCount { get; set; }

    public decimal? StatsMoney { get; set; }

    public int? StatsDay { get; set; }

    public string? StatsWard { get; set; }

    public string? StatsSuburb { get; set; }

    public string? StatsAreaCd { get; set; }

    public string? StatsStkCode { get; set; }

    public DateTime? StatsDate { get; set; }

    public string? StatsBorGroup { get; set; }

    public string? StatsBorClass { get; set; }

    public string? StatsUnique { get; set; }
}
