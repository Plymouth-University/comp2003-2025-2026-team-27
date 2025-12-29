using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class LibTab
{
    public string TabId { get; set; } = null!;

    public string? Description { get; set; }

    public bool? Active { get; set; }
}
