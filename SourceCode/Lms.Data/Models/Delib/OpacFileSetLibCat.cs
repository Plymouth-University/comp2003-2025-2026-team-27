using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class OpacFileSetLibCat
{
    public int SharedFileId { get; set; }

    public int FileNumberLib { get; set; }

    public int FileNumberCat { get; set; }

    public DateTime ExpirationDate { get; set; }

    public DateTime DateCreated { get; set; }

    public int FileOwnerBorNo { get; set; }

    public DateTime LastModifyOn { get; set; }
}
