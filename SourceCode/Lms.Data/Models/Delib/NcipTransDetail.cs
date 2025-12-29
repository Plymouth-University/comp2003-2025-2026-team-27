using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class NcipTransDetail
{
    public int? NcipNo { get; set; }

    public int? NcipToNo { get; set; }

    public int? WebSerialNo { get; set; }

    public DateTime? NcOrigDatetime { get; set; }

    public DateTime? NcUpdateDatetime { get; set; }

    public string? NcToAgency { get; set; }

    public string? NcFromAgency { get; set; }

    public string? NcOnbehalfAgency { get; set; }

    public string? NcRequestLocation { get; set; }

    public string? NcCollectLocation { get; set; }

    public string? NcComments { get; set; }

    public int? NcAction { get; set; }

    public int? NcStatusNo { get; set; }

    public string? NcAmlibItemBc { get; set; }

    public string? NcToItemBc { get; set; }

    public string? NcEnduserBc { get; set; }

    public string? NcLibraryborBc { get; set; }

    public int? NcResnoFrom { get; set; }

    public int? NcResnoTo { get; set; }

    public decimal? NcResCharge { get; set; }

    public string? NcItemDetails { get; set; }

    public string? NcBorrower { get; set; }

    public string? NcRequestId { get; set; }

    public DateTime? NcDateDueLender { get; set; }

    public DateTime? NcDateDue { get; set; }

    public int? NcLockOwner { get; set; }

    public DateTime? NcLockDate { get; set; }
}
