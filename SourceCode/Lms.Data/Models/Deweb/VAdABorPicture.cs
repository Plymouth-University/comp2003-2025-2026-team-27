using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VAdABorPicture
{
    public string? AuditType { get; set; }

    public int BorNo { get; set; }

    public string BorPicType { get; set; } = null!;

    public string BorPicFilename { get; set; } = null!;

    public byte[] BorPicData { get; set; } = null!;

    public DateTime? UpdatedOn { get; set; }
}
