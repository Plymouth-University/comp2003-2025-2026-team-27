using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorBiometric
{
    public int BorNo { get; set; }

    public short BorFingernumber { get; set; }

    public byte[]? BorFingerprint { get; set; }

    public bool? DeleteFlag { get; set; }
}
