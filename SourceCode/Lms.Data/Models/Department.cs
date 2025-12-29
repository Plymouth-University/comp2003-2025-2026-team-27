using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Department
{
    public int Id { get; set; }

    public int? DepId { get; set; }

    public string? DepCode { get; set; }

    public string? DepDesc { get; set; }

    public DateTime? DepCreated { get; set; }
}
