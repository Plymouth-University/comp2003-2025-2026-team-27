using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AConfigurationParameter
{
    public string ConfigParameterKey { get; set; } = null!;

    public string? ConfigParameterValue { get; set; }

    public string? ConfigurationDescription { get; set; }

    public int? DeleteFlag { get; set; }

    public string? Username { get; set; }

    public DateTime? LastUpdated { get; set; }
}
