using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class DynamicPageTemplate
{
    public int Templateid { get; set; }

    public string? TemplateTitle { get; set; }

    public string? TemplateContent { get; set; }

    public bool? Active { get; set; }
}
