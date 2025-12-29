using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CivisionMedium
{
    public string? AsGroup { get; set; }

    public string? AsType { get; set; }

    public int? AsEntity { get; set; }

    public int? AsSequence { get; set; }

    public string? AsFilename { get; set; }

    public string? AsWho { get; set; }

    public string? AsBrief { get; set; }

    public DateTime? AsDate { get; set; }

    public string? AsPlayVia { get; set; }
}
