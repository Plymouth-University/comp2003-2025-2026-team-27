using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Discussion
{
    public int DisId { get; set; }

    public int DisCatNo { get; set; }

    public int? DisBorNo { get; set; }

    public string? DisName { get; set; }

    public string? DisEmail { get; set; }

    public string DisResponse { get; set; } = null!;

    public DateTime DisResDatetime { get; set; }

    public string? DisApprovalOper { get; set; }

    public short? DisApprovalStatus { get; set; }

    public DateTime? DisApprovalDatetime { get; set; }
}
