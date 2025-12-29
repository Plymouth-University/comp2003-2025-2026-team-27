using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class IllLibrary
{
    public string IllCode { get; set; } = null!;

    public string? IllName { get; set; }

    public string? IllPhone { get; set; }

    public string? IllFax { get; set; }

    public string? IllEmail { get; set; }

    public string? IllPerson { get; set; }

    public string? IllAddr1 { get; set; }

    public string? IllAddr2 { get; set; }

    public string? IllAddr3 { get; set; }

    public string? IllPcode { get; set; }

    public string? IllCommType { get; set; }

    public int? IllZserverUniqueNo { get; set; }

    public string? IllNcipAgency { get; set; }

    public string? IllNcipLocation { get; set; }

    public string? IllNcipHost { get; set; }

    public int? IllNcipPort { get; set; }

    public decimal? IllCost { get; set; }

    public string? IllPassword { get; set; }

    public string? IllUsername { get; set; }

    public virtual ICollection<IllLibraryTranslation> IllLibraryTranslations { get; set; } = new List<IllLibraryTranslation>();
}
