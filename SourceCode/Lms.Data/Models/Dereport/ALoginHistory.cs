using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ALoginHistory
{
    public int AAnsUser { get; set; }

    public DateTime AccessDatetime { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public virtual AAnsUser AAnsUserNavigation { get; set; } = null!;
}
