using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CiFacCost
{
    public int? FcDay { get; set; }

    public decimal? FcCost { get; set; }

    public DateTime? FcStart { get; set; }

    public DateTime? FcEnd { get; set; }

    public int? FcFacNo { get; set; }
}
