using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class MainMenuApp
{
    public int MmaUnique { get; set; }

    public string? MmaLocation { get; set; }

    public string? MmaText { get; set; }

    public string? MmaPath { get; set; }

    public string? MmaFilename { get; set; }

    public virtual ICollection<MainMenuAppsTranslation> MainMenuAppsTranslations { get; set; } = new List<MainMenuAppsTranslation>();
}
