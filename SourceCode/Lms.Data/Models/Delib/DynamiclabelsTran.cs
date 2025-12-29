using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class DynamiclabelsTran
{
    public string LabelCode { get; set; } = null!;

    public string? Description { get; set; }

    public int Lcid { get; set; }
}
