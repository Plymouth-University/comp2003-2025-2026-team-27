using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class OpacApp
{
    public string AppId { get; set; } = null!;

    public string AppDesc { get; set; } = null!;

    public DateTime CreateDatetime { get; set; }

    public virtual ICollection<OpacAppsMenu> OpacAppsMenus { get; set; } = new List<OpacAppsMenu>();
}
