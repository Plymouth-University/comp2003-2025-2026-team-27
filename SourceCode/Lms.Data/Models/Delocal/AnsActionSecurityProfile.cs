using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AnsActionSecurityProfile
{
    public int ProfileId { get; set; }

    public int ActionId { get; set; }

    public bool Allow { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual AnsActionSecurity Action { get; set; } = null!;

    public virtual AnsProfile Profile { get; set; } = null!;
}
