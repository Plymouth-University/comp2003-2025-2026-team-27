using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class NcipXpath
{
    public int? NxId { get; set; }

    public int? NxMessageId { get; set; }

    public string? NxXpath { get; set; }

    public int? NxIsChoice { get; set; }

    public int? NxIsOptional { get; set; }

    public int? NxIsRepeatable { get; set; }

    public string? NxDataType { get; set; }

    public int? NxParentId { get; set; }

    public string? NxChoiceOption { get; set; }

    public int? NxChoiceGroupId { get; set; }

    public int? NxCgIsOptional { get; set; }

    public int? NxProblemType { get; set; }
}
