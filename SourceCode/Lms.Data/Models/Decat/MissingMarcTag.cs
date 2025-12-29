using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class MissingMarcTag
{
    public int? TagNo { get; set; }

    public string? Sf { get; set; }

    public string? MissingDesc { get; set; }

    public DateTime? DateLogged { get; set; }
}
