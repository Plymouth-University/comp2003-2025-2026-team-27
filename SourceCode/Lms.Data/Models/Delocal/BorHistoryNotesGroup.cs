using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class BorHistoryNotesGroup
{
    public int Id { get; set; }

    public int? CategoryId { get; set; }

    public string? Value { get; set; }

    public virtual BorHistoryNotesCategory? Category { get; set; }
}
