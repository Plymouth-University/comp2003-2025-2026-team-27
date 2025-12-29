using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class UserBorGroup
{
    public int Id { get; set; }

    public string BgGroup { get; set; } = null!;

    public int BorNo { get; set; }
}
