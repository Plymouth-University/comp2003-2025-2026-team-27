using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorFriend
{
    public int BorNo { get; set; }

    public int BorNoFriend { get; set; }

    public int BorFriendStatusId { get; set; }

    public virtual BorFriendStatus BorFriendStatus { get; set; } = null!;

    public virtual Borrower BorNoFriendNavigation { get; set; } = null!;

    public virtual Borrower BorNoNavigation { get; set; } = null!;
}
