using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class FinTypesTranslation
{
    public string FinType { get; set; } = null!;

    public int Lcid { get; set; }

    public string? FinDesc { get; set; }

    public virtual FinType FinTypeNavigation { get; set; } = null!;
}
