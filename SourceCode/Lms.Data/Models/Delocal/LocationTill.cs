using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LocationTill
{
    public int UniqueTillNo { get; set; }

    public string? TillIdentity { get; set; }

    public string? TillName { get; set; }

    public string TillGroup { get; set; } = null!;

    public string TillLocation { get; set; } = null!;

    public string? IsActive { get; set; }

    public int? BorNo { get; set; }
}
