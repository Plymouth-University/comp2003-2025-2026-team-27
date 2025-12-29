using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Destats;

public partial class UserSearch
{
    public string? UsOperName { get; set; }

    public DateTime? UsDatetime { get; set; }

    public string? UsModule { get; set; }

    public string? UsLocation { get; set; }

    public string? UsIpAddress { get; set; }

    public decimal? UsOperSecurity { get; set; }

    public string? UsSearchType { get; set; }

    public string? UsSearchTerms { get; set; }
}
