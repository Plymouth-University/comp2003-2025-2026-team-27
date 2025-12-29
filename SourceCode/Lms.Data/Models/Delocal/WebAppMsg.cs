using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class WebAppMsg
{
    public string? WamApp { get; set; }

    public string? WamUser { get; set; }

    public int? WamScreenNo { get; set; }

    public int? WamMsgNo { get; set; }

    public string? WamText { get; set; }

    public string? WamDesc { get; set; }
}
