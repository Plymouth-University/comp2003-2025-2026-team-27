using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibSection
{
    public string SectionId { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<LibSectionsTranslation> LibSectionsTranslations { get; set; } = new List<LibSectionsTranslation>();
}
