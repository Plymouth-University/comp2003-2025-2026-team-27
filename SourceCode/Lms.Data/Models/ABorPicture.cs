using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class ABorPicture
{
    public int BorNo { get; set; }

    public string BorPicType { get; set; } = null!;

    public string BorPicFilename { get; set; } = null!;

    public byte[] BorPicData { get; set; } = null!;
}
