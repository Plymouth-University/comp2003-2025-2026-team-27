using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class AnsProfile
{
    public int ProfileId { get; set; }

    public string? ProfileName { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }

    public bool? Administrator { get; set; }

    public virtual ICollection<Ans247libButtonProfile> Ans247libButtonProfiles { get; set; } = new List<Ans247libButtonProfile>();

    public virtual ICollection<Ans247libCircdeskConfigProfile> Ans247libCircdeskConfigProfiles { get; set; } = new List<Ans247libCircdeskConfigProfile>();

    public virtual ICollection<Ans247libScreenProfile> Ans247libScreenProfiles { get; set; } = new List<Ans247libScreenProfile>();

    public virtual ICollection<AnsActionSecurityProfile> AnsActionSecurityProfiles { get; set; } = new List<AnsActionSecurityProfile>();

    public virtual ICollection<AnsProfileOper> AnsProfileOpers { get; set; } = new List<AnsProfileOper>();
}
