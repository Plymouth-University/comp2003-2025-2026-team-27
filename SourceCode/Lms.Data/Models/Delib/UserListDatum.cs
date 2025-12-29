using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class UserListDatum
{
    public int ListId { get; set; }

    public int DataId { get; set; }

    public int? DataSequence { get; set; }

    public virtual UserListName List { get; set; } = null!;
}
