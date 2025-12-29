using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacOther
{
    public int? OpNo { get; set; }

    public string? OpDesc { get; set; }

    public string? OpCommand { get; set; }

    public string? OpSecurity { get; set; }

    public int? OpSeqNum { get; set; }

    public string? OpOperlist { get; set; }
}
