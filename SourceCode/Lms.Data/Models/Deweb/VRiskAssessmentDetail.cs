using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VRiskAssessmentDetail
{
    public int? CatNo { get; set; }

    public int? UniqueNo { get; set; }

    public int? SfSequence { get; set; }

    public string? RiskDetail { get; set; }

    public string? RiskLabel { get; set; }
}
