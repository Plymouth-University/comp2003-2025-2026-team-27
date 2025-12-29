using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CatleadthruTagsExtraTranslation
{
    public int Id { get; set; }

    public int Lcid { get; set; }

    public string? ClDesc { get; set; }

    public virtual CatleadthruTagsExtra IdNavigation { get; set; } = null!;
}
