using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class GroupMember
{
    public int GroupId { get; set; }

    public int BorNo { get; set; }

    public virtual Group Group { get; set; } = null!;
}
