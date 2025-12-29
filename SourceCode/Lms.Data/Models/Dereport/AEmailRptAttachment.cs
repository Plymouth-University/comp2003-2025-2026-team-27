using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AEmailRptAttachment
{
    public int AttachmentId { get; set; }

    public int AReport { get; set; }

    public string FileName { get; set; } = null!;

    public string MediaType { get; set; } = null!;

    public byte[] ContentStream { get; set; } = null!;

    public virtual AReport AReportNavigation { get; set; } = null!;
}
