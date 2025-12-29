using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class PerName
{
    public int? PnPerNo { get; set; }

    public string? PnYear { get; set; }

    public string? PnMonth { get; set; }

    public string? PnDay { get; set; }

    public string? PnWeekday { get; set; }

    public string? PnNum1Disp { get; set; }

    public int? PnNum1Start { get; set; }

    public int? PnNum1Rotate { get; set; }

    public string? PnNum2Disp { get; set; }

    public int? PnNum2Start { get; set; }

    public int? PnNum2Rotate { get; set; }

    public int? PnNum2Reset { get; set; }

    public string? PnTitlePrefix { get; set; }

    public string? PnTitleSuffix { get; set; }

    public int? PnDelay { get; set; }

    public string? PnExceptions { get; set; }

    public string? PnFormat { get; set; }

    public string? PnOper { get; set; }

    public DateTime? PnDatetime { get; set; }

    public string? PnNum3Disp { get; set; }

    public int? PnNum3Start { get; set; }

    public int? PnNum3Rotate { get; set; }

    public int? PnNum3Reset { get; set; }
}
