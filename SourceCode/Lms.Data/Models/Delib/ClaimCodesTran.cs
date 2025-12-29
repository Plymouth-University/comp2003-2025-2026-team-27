using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ClaimCodesTran
{
    public string ClCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? ClDescTrans { get; set; }
}
