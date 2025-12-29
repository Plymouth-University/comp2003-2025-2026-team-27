using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkItemPotentialCharge
{
    public int UniqueItemNo { get; set; }

    public int? BorNo { get; set; }

    public decimal? BorPotentialCharge { get; set; }

    public DateTime? LastUpdatedTime { get; set; }
}
