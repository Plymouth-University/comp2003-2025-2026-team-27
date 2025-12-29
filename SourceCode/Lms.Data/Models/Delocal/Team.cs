using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Team
{
    public int Id { get; set; }

    public int? DepId { get; set; }

    public int? TeamId { get; set; }

    public string? TeamCode { get; set; }

    public string? TeamDesc { get; set; }

    public DateTime? TeamCreated { get; set; }
}
