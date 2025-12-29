using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ReportFile
{
    public string? RfScreen { get; set; }

    public string? RfDesc { get; set; }

    public string? RfFilename { get; set; }

    public int? RfFileNo { get; set; }

    public string? RfMessage { get; set; }

    public string? ReportMessage { get; set; }

    public int? RfStatsCode { get; set; }

    public int? RfSubStats { get; set; }

    public string? RfCreateHistory { get; set; }

    public string? RfUpdate { get; set; }

    public int? RfType { get; set; }

    public string? RfLlCode { get; set; }
}
