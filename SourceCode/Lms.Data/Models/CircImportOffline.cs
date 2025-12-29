using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CircImportOffline
{
    public int? CioUniqueNo { get; set; }

    public string? CioProcess { get; set; }

    public DateTime? CioProcessDtime { get; set; }

    public string? CioProcMessages { get; set; }

    public string? CioType { get; set; }

    public string? CioBarcode { get; set; }

    public string? CioIssuedItem { get; set; }

    public string? CioOperator { get; set; }

    public string? CioLocation { get; set; }

    public DateTime? CioDatetime { get; set; }

    public string? CioInMessages { get; set; }
}
