using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class DbColumnDescriptionTranslation
{
    public int Id { get; set; }

    public int Lcid { get; set; }

    public string? ColumnDescription { get; set; }

    public virtual DbColumnDescription IdNavigation { get; set; } = null!;
}
