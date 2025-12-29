using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class StkSubscriber
{
    public int BorNo { get; set; }

    public int UniqueItemNo { get; set; }

    public DateTime CreateDatetime { get; set; }

    public string? UpdatedBy { get; set; }
}
