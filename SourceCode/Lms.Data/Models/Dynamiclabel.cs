using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Dynamiclabel
{
    public string LabelCode { get; set; } = null!;

    public string? Description { get; set; }

    public string? LabelDesc { get; set; }
}
