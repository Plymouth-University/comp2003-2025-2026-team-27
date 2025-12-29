using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StatsCode
{
    public int StatsType { get; set; }

    public string? StatsDescription { get; set; }

    public string? StatsLocation { get; set; }

    public string? StatsBorrower { get; set; }

    public string? StatsForm { get; set; }

    public string? StatsHour { get; set; }

    public string? StatsMonth { get; set; }

    public string? StatsYear { get; set; }

    public string? StatsCount { get; set; }

    public string? StatsMoney { get; set; }

    public string? StatsDay { get; set; }

    public string? StatsStkCode { get; set; }

    public string? StatsWard { get; set; }

    public string? StatsSuburb { get; set; }

    public string? StatsAreaCd { get; set; }

    public string? StatsGroup { get; set; }

    public string? StatsClass { get; set; }

    public virtual ICollection<StatsCodesTranslation> StatsCodesTranslations { get; set; } = new List<StatsCodesTranslation>();
}
