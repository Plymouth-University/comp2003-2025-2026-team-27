using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VOrdCondition
{
    public string OcCode { get; set; } = null!;

    public string? OcDesc { get; set; }

    public int? OrderId { get; set; }
}
