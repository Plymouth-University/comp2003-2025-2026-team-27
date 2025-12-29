using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorColumnsViewDetailsConfig
{
    public int Id { get; set; }

    public string LabelId { get; set; } = null!;

    public string TypeOfLabel { get; set; } = null!;
}
