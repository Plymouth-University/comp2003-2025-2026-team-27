using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class UserListName
{
    public int Id { get; set; }

    public string ListName { get; set; } = null!;

    public int? ListQty { get; set; }

    public string? ListDesc { get; set; }

    public DateTime? ListDateCreated { get; set; }

    public DateTime? ListDateUpdated { get; set; }

    public string? ListType { get; set; }

    public int? BorNo { get; set; }

    public virtual ICollection<UserListDatum> UserListData { get; set; } = new List<UserListDatum>();
}
