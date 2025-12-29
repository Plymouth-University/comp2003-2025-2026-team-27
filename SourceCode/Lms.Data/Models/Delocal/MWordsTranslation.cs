using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MWordsTranslation
{
    public int Lcid { get; set; }

    public int MId { get; set; }

    public string? MNotes { get; set; }

    public virtual MWord MIdNavigation { get; set; } = null!;
}
