using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VLookupParam
{
    public int ALookupParamId { get; set; }

    public string? Dbname { get; set; }

    public string ALookupParamName { get; set; } = null!;

    public string ALookupDefinition { get; set; } = null!;

    public bool DeleteFlag { get; set; }
}
