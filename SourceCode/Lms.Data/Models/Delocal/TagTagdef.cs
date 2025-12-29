using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagTagdef
{
    public int TtTagno { get; set; }

    public int? TtTagind1 { get; set; }

    public int? TtTagind2 { get; set; }

    public string? TtRepeatable { get; set; }

    public int? TtAuthtagno { get; set; }

    public int? TtKeeptag { get; set; }

    public string? TtTagdesc { get; set; }

    public string? TtTagformat { get; set; }

    public string? TtKdCode { get; set; }

    public string? TtUniqueAuth { get; set; }

    public string? TtSfformat { get; set; }

    public string? TtAllowCrossref { get; set; }

    public virtual ICollection<TagTagdefTranslation> TagTagdefTranslations { get; set; } = new List<TagTagdefTranslation>();
}
