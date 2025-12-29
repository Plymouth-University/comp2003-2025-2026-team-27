using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ClaimCode
{
    public string? ClCode { get; set; }

    public string? ClDesc { get; set; }

    public int? ClDays { get; set; }

    public int? OrderId { get; set; }
}
