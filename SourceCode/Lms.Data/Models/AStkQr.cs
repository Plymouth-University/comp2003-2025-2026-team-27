using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AStkQr
{
    public int UniqueItemNo { get; set; }

    public string StkQrType { get; set; } = null!;

    public string StkItemNo { get; set; } = null!;

    public byte[] StkQrData { get; set; } = null!;
}
