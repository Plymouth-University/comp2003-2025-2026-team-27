using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CiFacHour
{
    public DateTime? FhClose { get; set; }

    public int? FhFacNo { get; set; }

    public int? FhDay { get; set; }

    public DateTime? FhOpen { get; set; }
}
