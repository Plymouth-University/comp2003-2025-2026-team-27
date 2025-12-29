using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class GroupType
{
    public int GtId { get; set; }

    public string? GtName { get; set; }

    public int? LibGroupId { get; set; }

    public string? GtDescription { get; set; }
}
