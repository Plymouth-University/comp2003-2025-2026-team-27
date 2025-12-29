using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class DigitalWallet
{
    public int DwId { get; set; }

    public int? StkUniqueItemNo { get; set; }

    public int BorNo { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }

    public string? DwType { get; set; }

    public string? DwOper { get; set; }

    public string? LibGroup { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? FileName { get; set; }

    public int? RenewCount { get; set; }

    public string? DwStatus { get; set; }
}
