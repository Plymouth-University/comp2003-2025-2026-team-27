using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibLocFloor
{
    public int LlfId { get; set; }

    public string? LlfCode { get; set; }

    public string? LlCode { get; set; }

    public decimal? LlfCapacity { get; set; }

    public string? LgGroup { get; set; }

    public string? LlfDescription { get; set; }

    public virtual ICollection<LibLocFloorTranslation> LibLocFloorTranslations { get; set; } = new List<LibLocFloorTranslation>();
}
