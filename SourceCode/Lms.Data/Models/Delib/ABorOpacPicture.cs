using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ABorOpacPicture
{
    public string BorBarNo { get; set; } = null!;

    public long BorPicId { get; set; }

    public byte[]? BorData { get; set; }

    public string? BorPicType { get; set; }

    public string? BorPicFilename { get; set; }

    public string? BorPicUsed { get; set; }

    public string? BorPicDescription { get; set; }
}
