using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Destats;

public partial class StatsDuplicate
{
    public int? StatsType { get; set; }

    public string? StatsLlCode { get; set; }

    public string? StatsBorType { get; set; }

    public string? StatsStkForm { get; set; }

    public int? StatsHour { get; set; }

    public int? StatsMonth { get; set; }

    public int? StatsYear { get; set; }

    public double? StatsCount { get; set; }

    public double? StatsMoney { get; set; }

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
