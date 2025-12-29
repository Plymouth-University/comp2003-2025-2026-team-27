using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacRestrict
{
    public int? OrUnique { get; set; }

    public int? OrSequence { get; set; }

    public string? OrDesc { get; set; }

    public string? OrWhere { get; set; }
}
