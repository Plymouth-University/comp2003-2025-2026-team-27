using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class DynamicWebpage
{
    public string? Uniqueid { get; set; }

    public string? Author { get; set; }

    public string? DemoUrlLink { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? WebContent { get; set; }

    public string? LibGroup { get; set; }

    public bool? Active { get; set; }

    public int Id { get; set; }

    public string? Description { get; set; }
}
