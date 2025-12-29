using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class RepWhere
{
    public int? RepWhereNo { get; set; }

    public int? RepOrder { get; set; }

    public string? RepDescription { get; set; }

    public string? RepAddRight { get; set; }

    public string? RepOperJoin { get; set; }

    public string? RepOperEqual { get; set; }

    public string? RepLeftbracket { get; set; }

    public string? RepRightbracket { get; set; }

    public string? RepColName { get; set; }
}
