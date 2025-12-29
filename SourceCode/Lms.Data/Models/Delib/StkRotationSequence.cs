using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkRotationSequence
{
    public int RotationPlanId { get; set; }

    public int SequenceNo { get; set; }

    public int BorNo { get; set; }

    public int Period { get; set; }

    public int PeriodUnit { get; set; }
}
