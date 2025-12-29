using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class TagItemdefTranslation
{
    public int Lcid { get; set; }

    public int TiUnique { get; set; }

    public string? TiDescription { get; set; }
}
