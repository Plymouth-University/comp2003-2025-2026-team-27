using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorMessageThread
{
    public int ThreadId { get; set; }

    public int SubThreadId { get; set; }

    public int? ParentSubThreadId { get; set; }

    public DateTime ThreadDatetime { get; set; }

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public virtual ICollection<BorMessageRelThread> BorMessageRelThreads { get; set; } = new List<BorMessageRelThread>();
}
