using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class SoundTable
{
    public string? StActivated { get; set; }

    public int StUniqueNo { get; set; }

    public string? StEvent { get; set; }

    public string? StPath { get; set; }

    public string? StFileName { get; set; }

    public virtual ICollection<SoundTableTranslation> SoundTableTranslations { get; set; } = new List<SoundTableTranslation>();
}
