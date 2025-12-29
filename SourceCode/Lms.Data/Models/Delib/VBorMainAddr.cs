using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class VBorMainAddr
{
    public int BorNo { get; set; }

    public int? BorAddr1No { get; set; }

    public string BorAddr1Txt { get; set; } = null!;

    public int? BorAddr2No { get; set; }

    public string BorAddr2Txt { get; set; } = null!;

    public int? BorAddr3No { get; set; }

    public string BorAddr3Txt { get; set; } = null!;
}
