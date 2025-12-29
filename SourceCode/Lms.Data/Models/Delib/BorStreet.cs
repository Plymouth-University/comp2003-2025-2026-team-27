using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorStreet
{
    public string? BsStreet { get; set; }

    public string? BsWard { get; set; }

    public string? BsOddEven { get; set; }

    public int? BsStartNo { get; set; }

    public int? BsEndNo { get; set; }
}
