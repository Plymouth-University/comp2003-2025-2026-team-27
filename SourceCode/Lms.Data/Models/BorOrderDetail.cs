using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorOrderDetail
{
    public int? OrderId { get; set; }

    public int? ResNumber { get; set; }

    public int? PackingNumber { get; set; }

    public string? PackageLabel { get; set; }

    public int? ResPrintedItem { get; set; }
}
