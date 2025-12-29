using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class FinCurrency
{
    public string FcCode { get; set; } = null!;

    public string? FcDesc { get; set; }

    public decimal? FcRate { get; set; }

    public DateTime? FcDate { get; set; }

    public string? FcSymbol { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<FinCurrencyTranslation> FinCurrencyTranslations { get; set; } = new List<FinCurrencyTranslation>();
}
