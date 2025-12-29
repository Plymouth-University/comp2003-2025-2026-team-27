using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class FinConfiguration
{
    public string FinLibGroup { get; set; } = null!;

    public string FinKey { get; set; } = null!;

    public string? FinValue { get; set; }
}
