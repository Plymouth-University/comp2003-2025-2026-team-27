using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class TeamsRetCode
{
    public int Id { get; set; }

    public int? TeamId { get; set; }

    public int? RetId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }
}
