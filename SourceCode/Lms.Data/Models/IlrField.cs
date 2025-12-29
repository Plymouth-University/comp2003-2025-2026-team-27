using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class IlrField
{
    public int BorNo { get; set; }

    public int? Ethnicity { get; set; }

    public int? LlddhealthProb { get; set; }

    public string? Ninumber { get; set; }

    public int? PriorAttain { get; set; }

    public string? MathGrade { get; set; }

    public string? EngGrade { get; set; }

    public string? EmpStatusMonitor { get; set; }

    public int? EmpStat { get; set; }
}
