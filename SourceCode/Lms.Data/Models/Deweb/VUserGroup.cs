using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VUserGroup
{
    public int BorNo { get; set; }

    public string BgGroup { get; set; } = null!;

    public string? BgName { get; set; }

    public int? GtId { get; set; }

    public string? GtName { get; set; }

    public int? OrderId { get; set; }
}
