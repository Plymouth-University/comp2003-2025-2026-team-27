using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ans247libButtonProfile
{
    public int ProfileId { get; set; }

    public string ScreenName { get; set; } = null!;

    public string ButtonName { get; set; } = null!;

    public bool Allow { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual Ans247libButton Ans247libButton { get; set; } = null!;

    public virtual AnsProfile Profile { get; set; } = null!;
}
