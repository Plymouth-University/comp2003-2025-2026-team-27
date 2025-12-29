using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AdCatMarcLong
{
    public int AuditId { get; set; }

    public string? AuditType { get; set; }

    public int TagUniqueNo { get; set; }

    public string? CmlData { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
