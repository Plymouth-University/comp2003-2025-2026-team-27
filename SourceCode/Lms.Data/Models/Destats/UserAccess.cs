using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Destats;

public partial class UserAccess
{
    public string? UaOperName { get; set; }

    public DateTime? UaDatetime { get; set; }

    public string? UaModule { get; set; }

    public string? UaLocation { get; set; }

    public string? UaIpAddress { get; set; }

    public decimal? UaOperSecurity { get; set; }

    public decimal? UaObjectSecurity { get; set; }

    public string? UaObjectDetails { get; set; }

    public int UaId { get; set; }
}
