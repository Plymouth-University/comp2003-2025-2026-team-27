using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class DelegateStatus
{
    public int DelegateStatusid { get; set; }

    public string? StatusDescription { get; set; }

    public int? Visible { get; set; }
}
