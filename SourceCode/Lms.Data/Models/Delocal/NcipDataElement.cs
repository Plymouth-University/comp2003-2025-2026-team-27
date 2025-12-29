using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipDataElement
{
    public int? NdeId { get; set; }

    public string? NdeName { get; set; }

    public int? NdeVersionId { get; set; }

    public int? NdeIsClosedType { get; set; }
}
