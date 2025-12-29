using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AnsActionSecurity
{
    public int ActionId { get; set; }

    public string? ActionName { get; set; }

    public string ActionDesc { get; set; } = null!;

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public virtual ICollection<AnsActionSecurityOper> AnsActionSecurityOpers { get; set; } = new List<AnsActionSecurityOper>();

    public virtual ICollection<AnsActionSecurityProfile> AnsActionSecurityProfiles { get; set; } = new List<AnsActionSecurityProfile>();
}
