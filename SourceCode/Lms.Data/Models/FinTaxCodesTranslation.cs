using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinTaxCodesTranslation
{
    public int Lcid { get; set; }

    public string FtcCode { get; set; } = null!;

    public string? FtcDesc { get; set; }

    public virtual FinTaxCode FtcCodeNavigation { get; set; } = null!;
}
