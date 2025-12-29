using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class OperMessage
{
    public string? OmOperFrom { get; set; }

    public string? OmOperTo { get; set; }

    public string? OmMessage { get; set; }

    public string? OmSubject { get; set; }

    public DateTime? OmTimeToShow { get; set; }

    public string? OmSeen { get; set; }

    public string? OmReference { get; set; }

    public int? OmUnique { get; set; }
}
