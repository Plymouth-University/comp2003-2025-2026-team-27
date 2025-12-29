using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class CopyrightNotice
{
    public int Id { get; set; }

    public string UniqueId { get; set; } = null!;

    public string? TextContent { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LlCode { get; set; }

    public string? LlGroup { get; set; }
}
