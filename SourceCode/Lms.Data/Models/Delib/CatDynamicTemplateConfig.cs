using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CatDynamicTemplateConfig
{
    public string TemplateId { get; set; } = null!;

    public bool? ShowUniqueCheck { get; set; }

    public bool? ShowMatchCheck { get; set; }

    public bool? EnableDuplication { get; set; }

    public string? TempDesc { get; set; }
}
