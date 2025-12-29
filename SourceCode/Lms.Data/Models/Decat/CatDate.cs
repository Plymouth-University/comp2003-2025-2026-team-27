using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CatDate
{
    public int CdCatNo { get; set; }

    public int CdTagNo { get; set; }

    public string CdTagSf { get; set; } = null!;

    public DateTime CdDateFrom { get; set; }

    public DateTime CdDateTo { get; set; }
}
