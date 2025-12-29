using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkProcess
{
    public string? SpProcess { get; set; }

    public string? SpOpacShow { get; set; }

    public string? SpOperAlert { get; set; }

    public string? SpForLoan { get; set; }

    public string? SpRetRemove { get; set; }

    public int? OrderId { get; set; }
}
