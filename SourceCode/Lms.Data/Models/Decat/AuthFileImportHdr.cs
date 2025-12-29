using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AuthFileImportHdr
{
    public int? AfihNo { get; set; }

    public string? AfihHeader { get; set; }

    public int? AfihUserSerial { get; set; }

    public DateTime? AfihDate { get; set; }

    public string? AfihOriginal { get; set; }
}
