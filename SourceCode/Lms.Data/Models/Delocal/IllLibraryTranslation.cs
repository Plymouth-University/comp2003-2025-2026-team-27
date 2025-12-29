using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class IllLibraryTranslation
{
    public string IllCode { get; set; } = null!;

    public int Lcid { get; set; }

    public string? IllName { get; set; }

    public virtual IllLibrary IllCodeNavigation { get; set; } = null!;
}
