using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthorityChild
{
    public int AuthNoParent { get; set; }

    public int AuthNoChild { get; set; }

    public int? Lcid { get; set; }
}
