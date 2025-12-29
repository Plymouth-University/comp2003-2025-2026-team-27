using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ABorQr
{
    public int BorNo { get; set; }

    public string BorQrType { get; set; } = null!;

    public string BorQrFilename { get; set; } = null!;

    public byte[] BorQrData { get; set; } = null!;
}
