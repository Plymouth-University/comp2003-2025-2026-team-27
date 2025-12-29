using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Operator
{
    public string OperName { get; set; } = null!;

    public string? OperLastBor { get; set; }

    public string? OperLastCat { get; set; }

    public string? OperLastItem { get; set; }

    public string? OperPassword { get; set; }

    public string? OperLlCode { get; set; }

    public int? OperLevel { get; set; }

    public string? OperBorname1 { get; set; }

    public string? OperBorname2 { get; set; }

    public string? OperBorname3 { get; set; }

    public string? OperCatline1 { get; set; }

    public string? OperCatline2 { get; set; }

    public string? OperCatline3 { get; set; }

    public string? OperStkline3 { get; set; }

    public string? OperStkline2 { get; set; }

    public string? OperStkline1 { get; set; }

    public string? OperStk1 { get; set; }

    public string? OperStk2 { get; set; }

    public string? OperStk3 { get; set; }

    public string? OperCat3 { get; set; }

    public string? OperCat2 { get; set; }

    public string? OperCat1 { get; set; }

    public string? OperBor1 { get; set; }

    public string? OperBor2 { get; set; }

    public string? OperBor3 { get; set; }

    public DateTime? OperPwDue { get; set; }

    public string? OperHasSound { get; set; }

    public string? OperLastScreen { get; set; }

    public string? OperFixedLoc { get; set; }

    public string? OperAlowAllocate { get; set; }

    public string? LocalIdentifier { get; set; }

    public string? JobTitle { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? SupAccess { get; set; }

    public string? AccessAllGroups { get; set; }

    public DateTime? OperCreatedOn { get; set; }

    public string? OperCreatedBy { get; set; }

    public string? ParentConsentOverride { get; set; }

    public virtual ICollection<Ans247libButtonOper> Ans247libButtonOpers { get; set; } = new List<Ans247libButtonOper>();

    public virtual ICollection<Ans247libScreenOper> Ans247libScreenOpers { get; set; } = new List<Ans247libScreenOper>();

    public virtual ICollection<AnsActionSecurityOper> AnsActionSecurityOpers { get; set; } = new List<AnsActionSecurityOper>();

    public virtual ICollection<AnsProfileOper> AnsProfileOpers { get; set; } = new List<AnsProfileOper>();
}
