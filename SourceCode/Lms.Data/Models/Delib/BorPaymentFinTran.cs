using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorPaymentFinTran
{
    public int PayNo { get; set; }

    public int FinTranNo { get; set; }

    public decimal PayValue { get; set; }
}
