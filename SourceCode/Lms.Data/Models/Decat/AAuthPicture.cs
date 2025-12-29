using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AAuthPicture
{
    public int AuthNo { get; set; }

    public string AuthPicType { get; set; } = null!;

    public string AuthPicFilename { get; set; } = null!;

    public byte[] AuthPicData { get; set; } = null!;
}
