using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class FinTaxCode
{
    public string FtcCode { get; set; } = null!;

    public string? FtcDesc { get; set; }

    public decimal? FtcRate { get; set; }

    public virtual ICollection<FinTaxCodesTranslation> FinTaxCodesTranslations { get; set; } = new List<FinTaxCodesTranslation>();
}
