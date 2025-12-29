using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VBorPaymentFinTran
{
    public int PayNo { get; set; }

    public int FinTranNo { get; set; }

    public decimal PayValue { get; set; }
}
