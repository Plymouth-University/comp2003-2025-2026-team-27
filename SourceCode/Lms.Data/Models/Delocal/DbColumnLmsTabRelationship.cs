using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class DbColumnLmsTabRelationship
{
    public int Id { get; set; }

    public string LmsTabName { get; set; } = null!;

    public int DbColumnDescriptionId { get; set; }
}
