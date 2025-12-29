using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Opacuserquery
{
    public string? OuqLocation { get; set; }

    public string? OuqType { get; set; }

    public DateTime? OuqDate { get; set; }

    public string? OuqQuerydata { get; set; }

    public string? OuqResponse { get; set; }

    public string? LlCode { get; set; }

    public string? StkForm { get; set; }

    public string? StkGroup { get; set; }

    public string? StkCode { get; set; }

    public string? StkIsOnLoan { get; set; }

    public string? StkIsOnOrder { get; set; }

    public int? StkIsReserved { get; set; }

    public int? QuantityResult { get; set; }
}
