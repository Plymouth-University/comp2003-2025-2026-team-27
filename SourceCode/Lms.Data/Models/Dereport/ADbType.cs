using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class ADbType
{
    public short AnsDbType { get; set; }

    public string? Description { get; set; }

    public string? ProviderName { get; set; }

    public short Inactive { get; set; }

    public string? LastUpdatedBy { get; set; }

    public byte[] LastUpdatedOn { get; set; } = null!;
}
