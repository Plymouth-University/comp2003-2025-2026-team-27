using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MainMenuAppsTranslation
{
    public int Lcid { get; set; }

    public int MmaUnique { get; set; }

    public string? MmaText { get; set; }

    public virtual MainMenuApp MmaUniqueNavigation { get; set; } = null!;
}
