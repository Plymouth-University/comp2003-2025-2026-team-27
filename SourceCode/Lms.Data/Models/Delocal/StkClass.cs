using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkClass
{
    public string Code { get; set; } = null!;

    public string? ClassDesc { get; set; }

    public int? OrderId { get; set; }
}
