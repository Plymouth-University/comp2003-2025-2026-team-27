using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Group
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public virtual ICollection<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();
}
