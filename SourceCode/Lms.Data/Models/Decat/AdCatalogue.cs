using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class AdCatalogue
{
    public int AuditId { get; set; }

    public int? CatNo { get; set; }

    public int? CatNo1 { get; set; }

    public int? CatNo2 { get; set; }

    public int? CatNo3 { get; set; }

    public int? CatNo4 { get; set; }

    public string? CatStr1 { get; set; }

    public string? CatStr2 { get; set; }

    public string? CatStr3 { get; set; }

    public string? CatStr4 { get; set; }

    public string? CatOper { get; set; }

    public DateTime? CatDatetime { get; set; }

    public string? CatRestrict { get; set; }

    public string? CatKey1 { get; set; }

    public string? CatKey2 { get; set; }

    public string? CatKey3 { get; set; }

    public string? CatKey4 { get; set; }

    public string? CatLibGroup { get; set; }

    public string? CatCreateOper { get; set; }

    public DateTime? CatCreateDatetime { get; set; }

    public decimal? CatSecurity { get; set; }

    public string? CatStr5 { get; set; }

    public string? CatStr6 { get; set; }

    public string? CatStr7 { get; set; }

    public string? CatStr8 { get; set; }

    public DateTime? CatDate1 { get; set; }

    public DateTime? CatDate2 { get; set; }

    public DateTime? CatDate3 { get; set; }

    public DateTime? CatDate4 { get; set; }

    public string? CatPicType { get; set; }

    public string? CatPicFilename { get; set; }

    public byte[]? CatPicData { get; set; }

    public decimal? CatAvgRating { get; set; }

    public string? SeriesType { get; set; }

    public int? SeriesCatRefNo { get; set; }

    public string? CnPrefix { get; set; }

    public int? CnSuffix { get; set; }

    public string? TemplateId { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? AuditType { get; set; }
}
