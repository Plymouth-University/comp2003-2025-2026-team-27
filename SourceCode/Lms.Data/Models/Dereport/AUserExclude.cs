using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AUserExclude
{
    public string UserName { get; set; } = null!;

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }
}
