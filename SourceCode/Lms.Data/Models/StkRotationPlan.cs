using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class StkRotationPlan
{
    public int RotationPlanId { get; set; }

    public string RotationName { get; set; } = null!;
}
