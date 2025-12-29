using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class PerSubsFormat
{
    public long Id { get; set; }

    public string Format { get; set; } = null!;
}
