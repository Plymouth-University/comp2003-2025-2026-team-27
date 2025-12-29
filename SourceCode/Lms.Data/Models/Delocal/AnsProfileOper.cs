using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AnsProfileOper
{
    public int ProfileId { get; set; }

    public string OperName { get; set; } = null!;

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual Operator OperNameNavigation { get; set; } = null!;

    public virtual AnsProfile Profile { get; set; } = null!;
}
