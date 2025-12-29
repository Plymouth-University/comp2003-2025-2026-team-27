using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class DiyFlagsTranslation
{
    public int Lcid { get; set; }

    public string DiyType { get; set; } = null!;

    public int DiyNumber { get; set; }

    public int DiyParamNumber { get; set; }

    public string? DiyMessage { get; set; }

    public string? DiyComment { get; set; }

    public virtual DiyFlag DiyFlag { get; set; } = null!;
}
