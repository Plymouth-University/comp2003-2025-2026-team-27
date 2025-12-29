using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorHistory
{
    public string? BorBarNo { get; set; }

    public string? StkItemNo { get; set; }

    public string? StkTitle { get; set; }

    public DateTime? BhDate { get; set; }

    public string? BhType { get; set; }

    public DateTime? BhDueDate { get; set; }

    public string? BhComments { get; set; }

    public string? BhCode { get; set; }

    public string? BhReport { get; set; }
}
