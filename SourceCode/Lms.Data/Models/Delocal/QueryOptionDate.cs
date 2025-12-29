using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class QueryOptionDate
{
    public int QodId { get; set; }

    public string QodDesc { get; set; } = null!;

    public int QodType { get; set; }

    public int QodTagNo { get; set; }

    public string QodTagSf { get; set; } = null!;

    public string? QodOpacShow { get; set; }
}
