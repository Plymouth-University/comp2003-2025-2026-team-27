using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Calendar
{
    public DateTime? CaInvalidDate { get; set; }

    public string? CaDesc { get; set; }

    public string? LlCode { get; set; }
}
