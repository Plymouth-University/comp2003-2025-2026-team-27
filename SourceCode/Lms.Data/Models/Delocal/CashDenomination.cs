using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CashDenomination
{
    public int CashId { get; set; }

    public string Type { get; set; } = null!;

    public decimal? CashValue { get; set; }

    public string? DisplayText { get; set; }

    public int? SortOrder { get; set; }

    public string? IsActive { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }
}
