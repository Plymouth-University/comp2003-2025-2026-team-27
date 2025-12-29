using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorPayment
{
    public int PayNo { get; set; }

    public decimal PayValue { get; set; }

    public DateTime PayTransDate { get; set; }

    public string? PayLocation { get; set; }

    public string? PayOperator { get; set; }

    public string? PayLibGroup { get; set; }

    public string? FinType { get; set; }

    public int? CashTill { get; set; }
}
