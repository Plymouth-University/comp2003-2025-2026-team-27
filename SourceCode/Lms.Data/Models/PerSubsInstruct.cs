using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class PerSubsInstruct
{
    public int? PsPerNo { get; set; }

    public int? PsSubsNo { get; set; }

    public int? PsCopyNo { get; set; }

    public string? PsInstructions { get; set; }
}
