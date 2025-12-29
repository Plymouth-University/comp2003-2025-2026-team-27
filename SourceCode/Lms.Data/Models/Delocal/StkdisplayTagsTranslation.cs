using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class StkdisplayTagsTranslation
{
    public int Lcid { get; set; }

    public string StStkForm { get; set; } = null!;

    public string? StLine1 { get; set; }

    public string? StLine2 { get; set; }

    public string? StLine3 { get; set; }

    public string? StLine4 { get; set; }

    public string? StLine5 { get; set; }

    public string? StLine6 { get; set; }

    public string? StLine7 { get; set; }

    public string? StLine8 { get; set; }

    public string? StEdline { get; set; }

    public string? StVolline { get; set; }

    public string? StPriceline { get; set; }

    public string? StReceived { get; set; }

    public string? StAccessioned { get; set; }

    public virtual StkdisplayTag StStkFormNavigation { get; set; } = null!;
}
