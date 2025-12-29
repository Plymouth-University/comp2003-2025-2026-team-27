using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class CiWebAppSession
{
    public DateTime? WebDate { get; set; }

    public string? WebApp { get; set; }

    public string? WebId { get; set; }

    public int? WebSession { get; set; }

    public DateTime? WebStartSession { get; set; }

    public string? WebReload { get; set; }

    public string? WebAppClosed { get; set; }
}
