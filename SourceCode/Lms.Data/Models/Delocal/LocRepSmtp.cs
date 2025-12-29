using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LocRepSmtp
{
    public string? LrsLlCode { get; set; }

    public string? LrsRepScreen { get; set; }

    public int? LrsRtype { get; set; }

    public string? LrsSenderEmail { get; set; }

    public string? LrsBccEmail { get; set; }
}
