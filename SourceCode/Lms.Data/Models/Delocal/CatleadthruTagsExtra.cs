using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CatleadthruTagsExtra
{
    public int Id { get; set; }

    public string? ClDesc { get; set; }

    public string? ClTags { get; set; }

    public bool? Z3950default { get; set; }

    public bool? CreateCatDefault { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<CatleadthruTagsExtraTranslation> CatleadthruTagsExtraTranslations { get; set; } = new List<CatleadthruTagsExtraTranslation>();
}
