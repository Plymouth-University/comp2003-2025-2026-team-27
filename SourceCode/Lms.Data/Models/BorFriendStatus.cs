using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorFriendStatus
{
    public int BorFriendStatusId { get; set; }

    public string BorFriendStatusDesc { get; set; } = null!;

    public virtual ICollection<BorFriend> BorFriends { get; set; } = new List<BorFriend>();
}
