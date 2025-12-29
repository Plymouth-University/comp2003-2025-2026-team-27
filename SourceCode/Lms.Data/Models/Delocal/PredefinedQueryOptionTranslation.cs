using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class PredefinedQueryOptionTranslation
{
    public int PqoId { get; set; }

    public int Lcid { get; set; }

    public string? PqoDesc { get; set; }

    public virtual PredefinedQueryOption Pqo { get; set; } = null!;
}
