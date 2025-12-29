using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ans247libButtonOper
{
    public string ScreenName { get; set; } = null!;

    public string ButtonName { get; set; } = null!;

    public string OperName { get; set; } = null!;

    public bool Allow { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual Ans247libButton Ans247libButton { get; set; } = null!;

    public virtual Operator OperNameNavigation { get; set; } = null!;
}
