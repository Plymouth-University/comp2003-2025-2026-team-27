using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CatMaint
{
    public string? CmAuthCat { get; set; }

    public string? CmChangeType { get; set; }

    public DateTime? CmDate { get; set; }

    public int? CmUniqueNo { get; set; }
}
