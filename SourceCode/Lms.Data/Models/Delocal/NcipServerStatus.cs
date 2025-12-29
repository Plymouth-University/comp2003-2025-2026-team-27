using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipServerStatus
{
    public int? NssApp { get; set; }

    public int? NssState { get; set; }

    public int? NssStatus { get; set; }

    public string? NssMessage { get; set; }

    public string? NssIpAddress { get; set; }
}
