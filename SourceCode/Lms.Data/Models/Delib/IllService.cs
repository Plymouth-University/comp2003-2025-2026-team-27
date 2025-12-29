using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class IllService
{
    public string IllsCode { get; set; } = null!;

    public string IllsIllCode { get; set; } = null!;

    public string IllsKeywordDescription { get; set; } = null!;

    public decimal? IllsCost { get; set; }

    public virtual ICollection<IllServicesTranslation> IllServicesTranslations { get; set; } = new List<IllServicesTranslation>();
}
