using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Account
{
    public string Accno { get; set; } = null!;

    public string? AccnoDesc { get; set; }

    public string? AccnoCode1 { get; set; }

    public string? AccnoCode2 { get; set; }

    public string? AccnoCode3 { get; set; }

    public string? AccnoCode4 { get; set; }

    public string? AccnoType { get; set; }

    public int? AccnoStop { get; set; }

    public string AccnoLibGroup { get; set; } = null!;

    public virtual ICollection<AccountTranslation> AccountTranslations { get; set; } = new List<AccountTranslation>();
}
