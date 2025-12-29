using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagSfdef
{
    public string TsSf { get; set; } = null!;

    public string? TsSfDesc { get; set; }

    public string? TsRepeatable { get; set; }

    public string? TsKey { get; set; }

    public string? TsShared { get; set; }

    public int? TsSequence { get; set; }

    public int? TsAddTag { get; set; }

    public string? TsAddSf { get; set; }

    public int TsTagno { get; set; }

    public string? TsUnique { get; set; }

    public string? TsKeyword { get; set; }

    public string? TsMarc { get; set; }

    public string? TsDatatype { get; set; }

    public string? TsDateFlag { get; set; }

    public string? RisCode { get; set; }

    public string? RisDesc { get; set; }

    public string? TsStoplist { get; set; }

    public virtual ICollection<TagSfdefTranslation> TagSfdefTranslations { get; set; } = new List<TagSfdefTranslation>();
}
