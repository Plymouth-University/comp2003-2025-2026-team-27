using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibLocFloorTranslation
{
    public int Lcid { get; set; }

    public int LlfId { get; set; }

    public string? LlfCode { get; set; }

    public virtual LibLocFloor Llf { get; set; } = null!;
}
