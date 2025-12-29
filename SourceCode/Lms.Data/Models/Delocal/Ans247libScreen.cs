using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ans247libScreen
{
    public string ScreenName { get; set; } = null!;

    public string? ScreenDescription { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual ICollection<Ans247libButton> Ans247libButtons { get; set; } = new List<Ans247libButton>();

    public virtual ICollection<Ans247libScreenOper> Ans247libScreenOpers { get; set; } = new List<Ans247libScreenOper>();

    public virtual ICollection<Ans247libScreenProfile> Ans247libScreenProfiles { get; set; } = new List<Ans247libScreenProfile>();
}
