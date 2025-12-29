using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MWord
{
    public int? MType { get; set; }

    public string? MLookfor { get; set; }

    public string? MChangeto { get; set; }

    public int? MCharcount { get; set; }

    public string? MNotes { get; set; }

    public int MId { get; set; }

    public int? MPriority { get; set; }

    public virtual ICollection<MWordsTranslation> MWordsTranslations { get; set; } = new List<MWordsTranslation>();
}
