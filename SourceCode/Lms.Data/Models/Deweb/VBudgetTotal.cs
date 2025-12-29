using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VBudgetTotal
{
    public string? AccnoCode1 { get; set; }

    public string? AccnoCode2 { get; set; }

    public string? AccnoCode3 { get; set; }

    public string? AccnoCode4 { get; set; }

    public string? Accno { get; set; }

    public int GroupLevel { get; set; }

    public int? UniqueNo { get; set; }

    public string? AchAccount { get; set; }

    public string? Des { get; set; }

    public int? AchYear { get; set; }

    public int? AchUnique1 { get; set; }

    public int? AchUnique2 { get; set; }

    public int? AchUnique3 { get; set; }

    public int? AchUnique4 { get; set; }

    public string? LibGroup { get; set; }

    public decimal? Budget { get; set; }

    public decimal? Actual { get; set; }

    public decimal? AccCommit { get; set; }
}
