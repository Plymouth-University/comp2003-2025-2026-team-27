using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Dereport;

public partial class AQbuildForm
{
    public int AQbuildForm1 { get; set; }

    public int? FormType { get; set; }

    public string? FormName { get; set; }

    public string? SearchFormType { get; set; }

    public short? StartForm { get; set; }

    public int? AQbuildApp { get; set; }

    public int? AQbuildFormGrp { get; set; }

    public int? FormSequenceNo { get; set; }

    public string? FormPicklistSql { get; set; }

    public string? PicklistFields { get; set; }

    public short? AutopopSearchFrm { get; set; }

    public string? HeaderFormula { get; set; }

    public string? StoredProc { get; set; }

    public string? ProcedureParams { get; set; }

    public string? SpCallMode { get; set; }

    public string? NoDuplicates { get; set; }

    public string? FormPicklistSett { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? RefreshAfterSp { get; set; }

    public short? WebRecsPicklist { get; set; }

    public short? WebRecsPerTab { get; set; }

    public int? MaxPlCount { get; set; }

    public string? WebNullPlQuery { get; set; }

    public string? CompHtmlFile { get; set; }

    public string? FormPageHelp { get; set; }

    public string? SearchPageHelp { get; set; }

    public string? SpCallOrder { get; set; }

    public short? SpReturnError { get; set; }

    public virtual ICollection<AApplicationFlag> AApplicationFlags { get; set; } = new List<AApplicationFlag>();
}
