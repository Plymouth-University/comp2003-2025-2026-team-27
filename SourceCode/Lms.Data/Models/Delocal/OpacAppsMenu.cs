using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacAppsMenu
{
    public string AppId { get; set; } = null!;

    public string AppMenuId { get; set; } = null!;

    public string? AppMenuDesc { get; set; }

    public bool Show { get; set; }

    public virtual OpacApp App { get; set; } = null!;
}
