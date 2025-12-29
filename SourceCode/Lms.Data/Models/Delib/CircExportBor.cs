using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CircExportBor
{
    public string? CebBarcode { get; set; }

    public string? CebBorName { get; set; }

    public string? CebBorType { get; set; }

    public string? CebBorStatus { get; set; }

    public string? CebBanned { get; set; }

    public string? CebOverride { get; set; }

    public string? CebOwing { get; set; }

    public string? CebHasMemo { get; set; }
}
