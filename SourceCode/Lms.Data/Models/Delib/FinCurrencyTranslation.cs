using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class FinCurrencyTranslation
{
    public int Lcid { get; set; }

    public string FcCode { get; set; } = null!;

    public string? FcDesc { get; set; }

    public virtual FinCurrency FcCodeNavigation { get; set; } = null!;
}
