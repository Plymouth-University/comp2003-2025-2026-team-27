using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CiWebDatum
{
    public int? WebSerial { get; set; }

    public int? WebSeqStart { get; set; }

    public string? WebSet { get; set; }

    public string? WebString { get; set; }

    public DateTime? WebDate { get; set; }
}
