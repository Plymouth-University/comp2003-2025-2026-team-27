using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipMsgHistory
{
    public DateTime? NmhDate { get; set; }

    public int? NmhId { get; set; }

    public int? NmhApp { get; set; }

    public string? NmhMessage { get; set; }

    public string? NmhProtocol { get; set; }

    public string? NmhIpAddress { get; set; }

    public string? NmhErrors { get; set; }

    public string? NmhXml { get; set; }

    public int? NmhDirection { get; set; }
}
