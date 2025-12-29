using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Deweb;

public partial class VSuburb
{
    public string SuburbCode { get; set; } = null!;

    public string? SuburbName { get; set; }

    public string? SuburbPostcode { get; set; }

    public string? SuburbLlCode { get; set; }

    public int? OrderId { get; set; }
}
