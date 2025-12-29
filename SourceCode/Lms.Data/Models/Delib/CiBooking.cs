using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CiBooking
{
    public int? BkTotal { get; set; }

    public string? BkDesc { get; set; }

    public int? BkCatNo { get; set; }

    public string? BkBorName { get; set; }

    public DateTime? BkDatetime { get; set; }

    public string? BkOper { get; set; }

    public int? BkUnique { get; set; }

    public int? BkBorNo { get; set; }

    public string? BkBorKey { get; set; }

    public string? BkKey { get; set; }

    public DateTime? BkStartDate { get; set; }

    public int? BkFgNo { get; set; }

    public decimal? BkCost { get; set; }

    public DateTime? BkEndDate { get; set; }

    public decimal? BkCostPaid { get; set; }

    public decimal? BkTaxDue { get; set; }

    public int? BkFacNo { get; set; }

    public decimal? BkBondDue { get; set; }

    public decimal? BkBondPaid { get; set; }

    public string? BkReceipt { get; set; }

    public string? BkNotes { get; set; }
}
