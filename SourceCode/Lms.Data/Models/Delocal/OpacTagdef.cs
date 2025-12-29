using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacTagdef
{
    public int TtTagno { get; set; }

    public string? TtTagdesc { get; set; }

    public int? TtSequenceDetail { get; set; }

    public int? TtSequenceResult { get; set; }

    public virtual ICollection<OpacTagdefTranslation> OpacTagdefTranslations { get; set; } = new List<OpacTagdefTranslation>();
}
