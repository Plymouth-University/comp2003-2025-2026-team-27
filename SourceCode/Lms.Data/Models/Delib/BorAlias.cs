using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorAlias
{
    public int AliasBorNo { get; set; }

    public string? AliasName { get; set; }

    public string? AliasEmail { get; set; }

    public string? AliasPicFilename { get; set; }

    public string? AliasPicData { get; set; }
}
