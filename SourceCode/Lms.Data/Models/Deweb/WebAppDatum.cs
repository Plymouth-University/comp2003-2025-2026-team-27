using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class WebAppDatum
{
    public DateTime? WebDate { get; set; }

    public string? WebApp { get; set; }

    public int? WebSerial { get; set; }

    public string? WebSet { get; set; }

    public string? WebString { get; set; }
}
