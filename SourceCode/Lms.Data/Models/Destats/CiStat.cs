using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Destats;

public partial class CiStat
{
    public int? StatsType { get; set; }

    public string? StatsLlCode { get; set; }

    public int? StatsFacNo { get; set; }

    public string? StatsBorType { get; set; }

    public int? StatsHour { get; set; }

    public int? StatsMonth { get; set; }

    public int? StatsYear { get; set; }

    public int? StatsCount { get; set; }

    public decimal? StatsMoney { get; set; }

    public decimal? StatsTax { get; set; }

    public int? StatsDay { get; set; }

    public string? StatsWard { get; set; }

    public string? StatsSuburb { get; set; }

    public string? StatsAreaCd { get; set; }

    public string? StatsClass { get; set; }

    public DateTime? StatsDate { get; set; }

    public string? StatsFacEquip { get; set; }

    public string? StatsDiscCode { get; set; }
}
