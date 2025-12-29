using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ZwebMarcDatum
{
    public string? ZmdQueryId { get; set; }

    public int? ZmdServerId { get; set; }

    public int? ZmdRecord { get; set; }

    public string? ZmdMarc { get; set; }

    public DateTime? ZmdDatetime { get; set; }
}
