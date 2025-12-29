using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class LibSectionsTranslation
{
    public int Lcid { get; set; }

    public string SectionId { get; set; } = null!;

    public string? Description { get; set; }

    public virtual LibSection Section { get; set; } = null!;
}
