using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Decat;

public partial class TempCatMarcImport
{
    public int? UniqueId { get; set; }

    public int? InsertCatNo { get; set; }

    public string? InsertStatus { get; set; }

    public string? Notes { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? ImportCatOption { get; set; }

    public string? ImportOption { get; set; }

    public string? ImportStkOption { get; set; }

    public string? StkLocPermDf { get; set; }

    public string? StkStatsDf { get; set; }

    public string? StkLocFloorDf { get; set; }

    public string? StkProcess { get; set; }

    public string? StkFormDf { get; set; }

    public string? StkRefreshExceptLineDf { get; set; }

    public string? CatNoDeleteTags { get; set; }

    public string? CatNoImportTags { get; set; }

    public int? IsExistsCat { get; set; }

    public int? CatFileId { get; set; }

    public int? StkFileId { get; set; }

    public int? AuthFileId { get; set; }

    public string? FromZ3950Status { get; set; }

    public string? CatTemplateId { get; set; }

    public int? UniqueControlId { get; set; }
}
