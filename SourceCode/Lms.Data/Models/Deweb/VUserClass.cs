using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VUserClass
{
    public int BorNo { get; set; }

    public string BcClass { get; set; } = null!;

    public string? BcName { get; set; }

    public int? CtId { get; set; }

    public string? CtName { get; set; }

    public int? OrderId { get; set; }
}
