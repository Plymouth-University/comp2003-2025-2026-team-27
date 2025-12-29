using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ARef
{
    public string Ref { get; set; } = null!;

    public int Value { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }
}
