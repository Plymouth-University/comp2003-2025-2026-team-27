using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CatBorLike
{
    public int Id { get; set; }

    public int? CatNo { get; set; }

    public int? BorNo { get; set; }

    public DateTime? LastUpdatedOn { get; set; }
}
