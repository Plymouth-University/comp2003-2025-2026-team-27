using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipMsgAttr
{
    public int? NmaId { get; set; }

    public int? NmaItemId { get; set; }

    public int? NmaIsMessageId { get; set; }

    public string? NmaType { get; set; }

    public string? NmaAttribute { get; set; }

    public string? NmaValue { get; set; }
}
