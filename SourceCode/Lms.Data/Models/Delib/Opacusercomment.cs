using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class Opacusercomment
{
    public string? OucBorrower { get; set; }

    public string? OucLocation { get; set; }

    public string? OucType { get; set; }

    public DateTime? OucDate { get; set; }

    public string? OucResponse { get; set; }

    public string? OucComments { get; set; }

    public DateTime? OucLibdate { get; set; }

    public string? OucOper { get; set; }

    public int? OucNo { get; set; }

    public string? OucLine1 { get; set; }

    public string? OucLine2 { get; set; }

    public string? OucLine3 { get; set; }

    public string? OucLine4 { get; set; }

    public string? OucLine5 { get; set; }

    public string? OucLine6 { get; set; }

    public string? OucIsbn { get; set; }

    public string? OucForm { get; set; }

    public decimal? OucEstcost { get; set; }

    public string? OucCostaccept { get; set; }

    public string? OucOpacshow { get; set; }

    public string? OucNotes { get; set; }

    public string? OucOperRes { get; set; }

    public string? OucEmailStatus { get; set; }

    public string? OucLine7 { get; set; }

    public string? OucLine8 { get; set; }

    public string? OucLine9 { get; set; }

    public string? OucLine10 { get; set; }

    public string? OucDeliveryOption { get; set; }

    public string? OucDynamicline1 { get; set; }

    public string? OucDynamicline2 { get; set; }

    public string? OucDynamicline3 { get; set; }

    public string? OucDynamicline4 { get; set; }

    public string? OucDynamicline5 { get; set; }

    public string? UserTitle { get; set; }

    public string? UserGiven { get; set; }

    public string? UserSurname { get; set; }

    public string? UserEmail { get; set; }

    public int Id { get; set; }
}
