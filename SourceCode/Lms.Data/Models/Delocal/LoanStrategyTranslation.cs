using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LoanStrategyTranslation
{
    public string Code { get; set; } = null!;

    public int Lcid { get; set; }

    public string? Name { get; set; }

    public virtual LoanStrategy CodeNavigation { get; set; } = null!;
}
