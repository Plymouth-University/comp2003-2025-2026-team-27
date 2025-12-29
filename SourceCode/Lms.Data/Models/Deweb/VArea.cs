using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VArea
{
    public string? AreaName { get; set; }

    public string AreaCode { get; set; } = null!;

    public int? OrderId { get; set; }
}
