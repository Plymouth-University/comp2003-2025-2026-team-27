using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorOrderBasket
{
    public int BorNo { get; set; }

    public int UniqueItemNo { get; set; }

    public DateTime CreateDatetime { get; set; }
}
