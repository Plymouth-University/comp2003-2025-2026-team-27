using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorEditCatalogue
{
    public int? BorNo { get; set; }

    public int? CatNo { get; set; }

    public string? EditStatus { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public DateTime? LastUpdatedOn { get; set; }
}
