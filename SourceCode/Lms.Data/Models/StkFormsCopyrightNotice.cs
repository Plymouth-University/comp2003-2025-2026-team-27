using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class StkFormsCopyrightNotice
{
    public int? CopyrightNoticeId { get; set; }

    public string? StkForm { get; set; }

    public string? LlCode { get; set; }

    public string? LlGroup { get; set; }
}
