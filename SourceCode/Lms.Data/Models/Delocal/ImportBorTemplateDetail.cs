using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ImportBorTemplateDetail
{
    public int TemplateId { get; set; }

    public int ColId { get; set; }

    public bool IsMandatory { get; set; }

    public int? SortId { get; set; }
}
