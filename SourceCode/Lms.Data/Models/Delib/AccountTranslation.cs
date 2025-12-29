using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class AccountTranslation
{
    public int Lcid { get; set; }

    public string AccnoLibGroup { get; set; } = null!;

    public string Accno { get; set; } = null!;

    public string? AccnoDesc { get; set; }

    public virtual Account Account { get; set; } = null!;
}
