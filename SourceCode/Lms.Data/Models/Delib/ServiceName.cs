using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class ServiceName
{
    public string? Description { get; set; }

    public int ServiceNameId { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
