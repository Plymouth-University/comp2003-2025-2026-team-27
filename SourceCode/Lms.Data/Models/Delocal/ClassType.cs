using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ClassType
{
    public int CtId { get; set; }

    public string? CtName { get; set; }

    public int? LibGroupId { get; set; }

    public string? CtDescription { get; set; }
}
