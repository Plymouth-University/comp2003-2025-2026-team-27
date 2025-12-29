using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class BorGroupDetail
{
    public int BgId { get; set; }

    public int BorFriendNo { get; set; }

    public virtual BorGroupMsg Bg { get; set; } = null!;
}
