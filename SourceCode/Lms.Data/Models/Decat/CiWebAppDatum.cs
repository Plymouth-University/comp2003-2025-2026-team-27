using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CiWebAppDatum
{
    public DateTime? WebDate { get; set; }

    public int? WebSerial { get; set; }

    public string? WebApp { get; set; }

    public string? WebSet { get; set; }

    public string? WebString { get; set; }
}
