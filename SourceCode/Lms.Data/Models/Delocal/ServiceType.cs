using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ServiceType
{
    public int ServiceTypeid { get; set; }

    public string? Description { get; set; }

    public int? Visible { get; set; }
}
