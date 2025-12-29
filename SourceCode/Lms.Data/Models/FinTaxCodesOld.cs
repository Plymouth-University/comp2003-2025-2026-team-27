using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinTaxCodesOld
{
    public string? FtcCode { get; set; }

    public string? FtcDesc { get; set; }

    public decimal? FtcRate { get; set; }
}
