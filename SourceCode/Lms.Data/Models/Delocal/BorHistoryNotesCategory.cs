using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorHistoryNotesCategory
{
    public int BhnCategoryId { get; set; }

    public string? BhnCategory { get; set; }

    public virtual ICollection<BorHistoryNotesGroup> BorHistoryNotesGroups { get; set; } = new List<BorHistoryNotesGroup>();
}
