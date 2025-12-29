using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class Series
{
    public int? ParentCatNo { get; set; }

    public int? ChildCatNo { get; set; }
}
