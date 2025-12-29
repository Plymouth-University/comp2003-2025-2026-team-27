using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VMonthlyStat
{
    public string MsLlCode { get; set; } = null!;

    public int TransType { get; set; }

    public int MsMonth { get; set; }

    public int MsYear { get; set; }

    public int MsCount { get; set; }
}
