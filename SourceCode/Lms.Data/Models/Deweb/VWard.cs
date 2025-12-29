using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VWard
{
    public string? WardName { get; set; }

    public string WardCode { get; set; } = null!;

    public int? OrderId { get; set; }
}
