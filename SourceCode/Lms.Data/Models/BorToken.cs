using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class BorToken
{
    public int TokenId { get; set; }

    public int Borno { get; set; }

    public string? Token { get; set; }

    public DateTime? IssuedOn { get; set; }

    public DateTime? ExpiresOn { get; set; }
}
