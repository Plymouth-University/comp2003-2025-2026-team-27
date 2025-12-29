using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipMessage
{
    public int? NmId { get; set; }

    public string? NmMessage { get; set; }

    public int? NmVersionId { get; set; }

    public int? NmCached { get; set; }
}
