using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorMemo
{
    public int? BmBorNo { get; set; }

    public DateTime? BmEffDate { get; set; }

    public string? BmDisplay { get; set; }

    public string? BmData { get; set; }

    public string? BmType { get; set; }

    public string? BmStkItemNo { get; set; }

    public string? BmBorBarNo { get; set; }

    public string? BmUniqueNo { get; set; }

    public DateTime? BmEndDate { get; set; }
}
