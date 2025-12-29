using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ZwebScanCache
{
    public string? ZsUniqueId { get; set; }

    public int? ZsServerId { get; set; }

    public string? ZsServerDescription { get; set; }

    public int? ZsAttrId { get; set; }

    public string? ZsDisplay { get; set; }

    public string? ZsKey { get; set; }

    public int? ZsFound { get; set; }

    public DateTime? ZsDatetime { get; set; }
}
