using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ans247libButton
{
    public string ScreenName { get; set; } = null!;

    public string ButtonName { get; set; } = null!;

    public string? ButtonText { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual ICollection<Ans247libButtonOper> Ans247libButtonOpers { get; set; } = new List<Ans247libButtonOper>();

    public virtual ICollection<Ans247libButtonProfile> Ans247libButtonProfiles { get; set; } = new List<Ans247libButtonProfile>();

    public virtual Ans247libScreen ScreenNameNavigation { get; set; } = null!;
}
