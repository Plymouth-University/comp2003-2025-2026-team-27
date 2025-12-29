using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NetRestrict
{
    public int? NetDay { get; set; }

    public int? NetHourFrom { get; set; }

    public int? NetHourTo { get; set; }

    public int? NetQty { get; set; }

    public int? NetLowLogins { get; set; }

    public int? NetLowQty { get; set; }

    public string? NetLlCode { get; set; }

    public string? NetEntCode { get; set; }
}
