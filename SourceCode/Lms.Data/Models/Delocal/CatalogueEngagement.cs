using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class CatalogueEngagement
{
    public int Id { get; set; }

    public string? CatTemplateId { get; set; }

    public string? BorTypeId { get; set; }

    public string? CanRate { get; set; }

    public string? CanLike { get; set; }

    public string? CanPromote { get; set; }

    public int? RateWeight { get; set; }

    public int? PromoteWeight { get; set; }

    public string? CanAddViews { get; set; }

    public string LlCode { get; set; } = null!;

    public int? EngPriority { get; set; }
}
