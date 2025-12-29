using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AValidEmailPlaceholder
{
    public int HolderId { get; set; }

    public int ReportGroupId { get; set; }

    public string? PlaceHolder { get; set; }

    public string? Description { get; set; }

    public virtual AReportGroup ReportGroup { get; set; } = null!;
}
