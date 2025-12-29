using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AFileSetLibCat
{
    public int FileNumberLib { get; set; }

    public int FileNumberCat { get; set; }

    public DateTime ExpirationDate { get; set; }

    public string LastModifyBy { get; set; } = null!;

    public DateTime LastModifyOn { get; set; }
}
