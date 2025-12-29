using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CiBookFlag
{
    public int? BkfFacNo { get; set; }

    public int? BkfTimecode { get; set; }

    public DateTime? BkfTimeactual { get; set; }

    public int? BkfUnique { get; set; }

    public int? BkfFgNo { get; set; }

    public DateTime? BkfExpires { get; set; }

    public string? BkfTemp { get; set; }

    public DateTime? BkfDatetime { get; set; }

    public string? BkfOper { get; set; }
}
