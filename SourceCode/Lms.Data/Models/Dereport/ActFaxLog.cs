using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ActFaxLog
{
    public int AnsFaxId { get; set; }

    public string? Company { get; set; }

    public string? Contact { get; set; }

    public string? FaxNo { get; set; }

    public DateTime? DatetimeSent { get; set; }

    public string? FaxStatus { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? FaxSentBy { get; set; }
}
