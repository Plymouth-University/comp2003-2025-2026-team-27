using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Suburb
{
    public string SuburbCode { get; set; } = null!;

    public string? SuburbName { get; set; }

    public string? SuburbPostcode { get; set; }

    public string? SuburbLlCode { get; set; }

    public int? OrderId { get; set; }

    public virtual ICollection<SuburbTranslation> SuburbTranslations { get; set; } = new List<SuburbTranslation>();
}
