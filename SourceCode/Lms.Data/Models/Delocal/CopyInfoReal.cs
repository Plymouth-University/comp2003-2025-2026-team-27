using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CopyInfoReal
{
    public int Id { get; set; }

    public string? MarcTag { get; set; }

    public string? SubField { get; set; }

    public string? AlreadyInDb { get; set; }

    public string? DateAddedInDb { get; set; }

    public string? ImportName { get; set; }
}
