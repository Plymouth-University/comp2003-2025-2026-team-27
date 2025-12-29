using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class SoundTableTranslation
{
    public int Lcid { get; set; }

    public int StUniqueNo { get; set; }

    public string? StEvent { get; set; }

    public virtual SoundTable StUniqueNoNavigation { get; set; } = null!;
}
