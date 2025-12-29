using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ACatReadingList
{
    public long ListId { get; set; }

    public int CatNo { get; set; }

    public long Priority { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public virtual ABorReadingList List { get; set; } = null!;
}
