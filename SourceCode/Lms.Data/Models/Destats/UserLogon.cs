using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Destats;

public partial class UserLogon
{
    public string? UlOperName { get; set; }

    public DateTime? UlDatetime { get; set; }

    public string? UlModule { get; set; }

    public string? UlLocation { get; set; }

    public string? UlIpAddress { get; set; }

    public int UlId { get; set; }
}
