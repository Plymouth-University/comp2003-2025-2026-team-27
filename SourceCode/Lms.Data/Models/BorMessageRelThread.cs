using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorMessageRelThread
{
    public int BorNo { get; set; }

    public int ThreadId { get; set; }

    public int SubThreadId { get; set; }

    public bool Display { get; set; }

    public int OwnerNo { get; set; }

    public bool Unread { get; set; }

    public virtual BorMessageThread BorMessageThread { get; set; } = null!;

    public virtual Borrower BorNoNavigation { get; set; } = null!;
}
