using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibLocationsTranslation
{
    public int Lcid { get; set; }

    public string LlGroup { get; set; } = null!;

    public string LlCode { get; set; } = null!;

    public string? LlName { get; set; }

    public virtual LibLocation LibLocation { get; set; } = null!;
}
