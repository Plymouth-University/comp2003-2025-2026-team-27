using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AnsActionSecurityOper
{
    public int ActionId { get; set; }

    public string OperName { get; set; } = null!;

    public bool Allow { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual AnsActionSecurity Action { get; set; } = null!;

    public virtual Operator OperNameNavigation { get; set; } = null!;
}
