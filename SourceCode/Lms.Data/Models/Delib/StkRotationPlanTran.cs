using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkRotationPlanTran
{
    public int RotationPlanId { get; set; }

    public int Lcid { get; set; }

    public string? RotationNameTrans { get; set; }
}
