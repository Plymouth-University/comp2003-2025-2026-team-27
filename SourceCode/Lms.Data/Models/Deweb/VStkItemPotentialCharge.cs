using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VStkItemPotentialCharge
{
    public int UniqueItemNo { get; set; }

    public int? BorNo { get; set; }

    public decimal? BorPotentialCharge { get; set; }

    public DateTime? LastUpdatedTime { get; set; }
}
