using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ImportWondeBorTemplateDetail
{
    public int TemplateId { get; set; }

    public int BorColId { get; set; }

    public int WonColId { get; set; }

    public bool IsMandatory { get; set; }

    public int? SortId { get; set; }
}
