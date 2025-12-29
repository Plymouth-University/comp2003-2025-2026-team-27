using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VLibLocation
{
    public string LlCode { get; set; } = null!;

    public string? LlName { get; set; }

    public string LlGroup { get; set; } = null!;

    public int? OrderId { get; set; }
}
