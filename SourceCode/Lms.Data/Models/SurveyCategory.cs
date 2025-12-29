using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class SurveyCategory
{
    public string CategoryId { get; set; } = null!;

    public string? CategoryDesc { get; set; }

    public string? CategoryHtml { get; set; }

    public int? SurveyType { get; set; }
}
