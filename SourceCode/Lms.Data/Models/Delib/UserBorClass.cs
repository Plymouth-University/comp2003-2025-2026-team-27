using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class UserBorClass
{
    public int Id { get; set; }

    public string BcClass { get; set; } = null!;

    public int BorNo { get; set; }
}
