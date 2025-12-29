using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class DbColumnDescription
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string ColumnName { get; set; } = null!;

    public string? ColumnDescription { get; set; }

    public virtual ICollection<DbColumnDescriptionTranslation> DbColumnDescriptionTranslations { get; set; } = new List<DbColumnDescriptionTranslation>();

    public virtual ICollection<TableViewConfig> TableViewConfigs { get; set; } = new List<TableViewConfig>();
}
