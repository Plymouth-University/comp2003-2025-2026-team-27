using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ImportWondeBorTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? TemplateDesc { get; set; }

    public int? LibGroupId { get; set; }

    public int? ClassTemplateId { get; set; }

    public int? GroupTemplateId { get; set; }

    public string? DefaultUserGroup { get; set; }

    public string? DefaultUserClass { get; set; }

    public string? DefaultUserType { get; set; }

    public string? DefaultUserLocation { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreateDatetime { get; set; }
}
