using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Opacuserreply
{
    public string? OucrBorrower { get; set; }

    public string? OucrLocation { get; set; }

    public string? OucrType { get; set; }

    public DateTime? OucrDate { get; set; }

    public string? OucrResponse { get; set; }

    public string? OucrLibresponse { get; set; }

    public DateTime? OucrLibdate { get; set; }

    public string? OucrOper { get; set; }

    public int? OucrNo { get; set; }

    public string? OucrEmailStatus { get; set; }
}
