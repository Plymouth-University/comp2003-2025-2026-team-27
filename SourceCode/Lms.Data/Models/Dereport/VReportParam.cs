using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class VReportParam
{
    public int AReportParam { get; set; }

    public int AReport { get; set; }

    public string ParamName { get; set; } = null!;

    public string? ParamDesc { get; set; }

    public string? DataField { get; set; }

    public string? DataEquation { get; set; }

    public byte[]? LookUp { get; set; }

    public string Mandatory { get; set; } = null!;

    public string? DefaultOperator { get; set; }

    public string? DefaultValue { get; set; }

    public string? PassToCrw { get; set; }

    public string? Coltype { get; set; }

    public string? PassToSp { get; set; }

    public short? SpParamOrderNo { get; set; }

    public string? PreStoredProc { get; set; }

    public string? PostStoredProc { get; set; }

    public string? PreReportParam { get; set; }

    public string? PostReportParam { get; set; }

    public short? PreParamOrderno { get; set; }

    public short? PostParamOrderno { get; set; }

    public string? DisplayOperator { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateTime { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? PreStoredParam { get; set; }

    public string? PostStoredParam { get; set; }

    public string? OpenBrace { get; set; }

    public string? CloseBrace { get; set; }

    public string? NotOperator { get; set; }

    public string? AndOrOperator { get; set; }

    public string? Dbname { get; set; }

    public string? ALookupParamName { get; set; }

    public string? ALookupDefinition { get; set; }
}
