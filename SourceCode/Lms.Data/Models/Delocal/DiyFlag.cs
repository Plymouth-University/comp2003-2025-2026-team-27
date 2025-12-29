using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class DiyFlag
{
    public string DiyType { get; set; } = null!;

    public int DiyNumber { get; set; }

    public string? DiyProceed { get; set; }

    public int? DiySound { get; set; }

    public string? DiyMessage { get; set; }

    public string? DiyComment { get; set; }

    public int DiyParamNumber { get; set; }

    public virtual ICollection<DiyFlagsTranslation> DiyFlagsTranslations { get; set; } = new List<DiyFlagsTranslation>();
}
