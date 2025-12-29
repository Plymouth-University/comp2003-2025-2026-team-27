using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class Client
{
    public string ClientName { get; set; } = null!;

    public int ClientNumber { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateOp { get; set; } = null!;

    public DateTime LastUpDate { get; set; }

    public string LastUpOp { get; set; } = null!;

    public byte[]? ClientComment { get; set; }

    public string? IndustryType { get; set; }

    public string? WebbAddr { get; set; }

    public int? ParentNumber { get; set; }

    public short? CliBillbackAc { get; set; }

    public short? CliBillbackEv { get; set; }

    public string? ExternalId { get; set; }

    public short? ShowAccomSavings { get; set; }

    public short? ShowEventSavings { get; set; }

    public short? CostCentreReqacc { get; set; }

    public short? CostCentreReqev { get; set; }

    public virtual ICollection<AClientReport> AClientReports { get; set; } = new List<AClientReport>();

    public virtual ICollection<Site> Sites { get; set; } = new List<Site>();
}
