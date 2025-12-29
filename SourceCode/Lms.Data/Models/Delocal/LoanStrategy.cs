using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LoanStrategy
{
    public string? Name { get; set; }

    public string Code { get; set; } = null!;

    public int? OrderId { get; set; }

    public virtual ICollection<LoanStrategyTranslation> LoanStrategyTranslations { get; set; } = new List<LoanStrategyTranslation>();
}
