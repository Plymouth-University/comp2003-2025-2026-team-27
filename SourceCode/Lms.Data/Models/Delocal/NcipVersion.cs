using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipVersion
{
    public int? NvId { get; set; }

    public string? NvVersion { get; set; }

    public string? NvVersionXsd { get; set; }

    public string? NvVersionDtd { get; set; }

    public int? NvValid { get; set; }
}
