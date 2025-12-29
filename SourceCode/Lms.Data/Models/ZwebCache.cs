using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ZwebCache
{
    public string? ZcType { get; set; }

    public string? ZcUniqueId { get; set; }

    public string? ZcData { get; set; }

    public DateTime? ZcDatetime { get; set; }
}
