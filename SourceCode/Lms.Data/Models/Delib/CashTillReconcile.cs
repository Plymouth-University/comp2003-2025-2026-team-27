using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CashTillReconcile
{
    public int Id { get; set; }

    public int? TillId { get; set; }

    public decimal? OpeningBalance { get; set; }

    public decimal? TotalWithdrawn { get; set; }

    public decimal? ClosingBalance { get; set; }

    public string? RecordedBy { get; set; }

    public DateTime? RecordedOn { get; set; }

    public decimal? BalDifference { get; set; }

    public string? Comment { get; set; }

    public int? ReconcileId { get; set; }
}
