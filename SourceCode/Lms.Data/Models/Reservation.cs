using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class Reservation
{
    public string? ResBorNo { get; set; }

    public string? ResCollLoc { get; set; }

    public DateTime? ResDate { get; set; }

    public DateTime? ResExpiry { get; set; }

    public int? ResNumber { get; set; }

    public int? ResPriority { get; set; }

    public string? ResStkItem { get; set; }

    public string? ResAllOrFirst { get; set; }

    public string? ResAllSameTitle { get; set; }

    public string? ResPlacedLoc { get; set; }

    public string? ResWhoPlaced { get; set; }

    public string? ResStatus { get; set; }

    public DateTime? ResNotifyDate { get; set; }

    public string? ResFutureRes { get; set; }

    public DateTime? ResReqFrom { get; set; }

    public DateTime? ResReqTo { get; set; }

    public int? ResBorAddrNo { get; set; }
}
