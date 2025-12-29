using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ans247libLabel
{
    public string ScreenName { get; set; } = null!;

    public string? LabelName { get; set; }

    public string? LabelText { get; set; }

    public string? RelatedControl { get; set; }

    public string? Visible { get; set; }

    public DateTime? LastUpdateOn { get; set; }

    public string? LastUpdateBy { get; set; }
}
