using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ImportWondeBorGrpTemplate
{
    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? TemplateDesc { get; set; }

    public int? LibGroupId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreateDatetime { get; set; }
}
