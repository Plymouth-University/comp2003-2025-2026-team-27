using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class LibLocation
{
    public string LlCode { get; set; } = null!;

    public string? LlName { get; set; }

    public string LlGroup { get; set; } = null!;

    public int? OrderId { get; set; }

    public string? DefaultStkClass { get; set; }

    public string? LlEmail { get; set; }

    public string? TelNo { get; set; }

    public string? FaxNo { get; set; }

    public string? AddressLine1 { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? AddressLine4 { get; set; }

    public string? Postcode { get; set; }

    public string? ClusterName { get; set; }

    public string? LocAlias { get; set; }

    public virtual ICollection<LibLocationsTranslation> LibLocationsTranslations { get; set; } = new List<LibLocationsTranslation>();
}
