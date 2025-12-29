using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AOpacBorSearchCatFilter
{
    public int SearchId { get; set; }

    public int CatFilterId { get; set; }

    public string CatColumn { get; set; } = null!;

    public string FilterOperator { get; set; } = null!;

    public string? FilterStrValue { get; set; }

    public DateTime? FilterDatetimeValue { get; set; }

    public virtual AOpacBorSearch Search { get; set; } = null!;
}
