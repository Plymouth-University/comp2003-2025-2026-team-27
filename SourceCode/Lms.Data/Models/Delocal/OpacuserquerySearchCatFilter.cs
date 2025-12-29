using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacuserquerySearchCatFilter
{
    public string OuqLocation { get; set; } = null!;

    public string OuqType { get; set; } = null!;

    public DateTime OuqDate { get; set; }

    public int CatFilterId { get; set; }

    public string CatColumn { get; set; } = null!;

    public string FilterOperator { get; set; } = null!;

    public string? FilterStrValue { get; set; }

    public DateTime? FilterDatetimeValue { get; set; }
}
