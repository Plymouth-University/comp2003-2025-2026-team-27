using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorGroupMsg
{
    public int BgId { get; set; }

    public string BgDescription { get; set; } = null!;

    public int BgOwnerId { get; set; }

    public virtual Borrower BgOwner { get; set; } = null!;

    public virtual ICollection<BorGroupDetail> BorGroupDetails { get; set; } = new List<BorGroupDetail>();
}
