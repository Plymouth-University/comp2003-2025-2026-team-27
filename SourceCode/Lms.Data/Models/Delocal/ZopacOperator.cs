using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class ZopacOperator
{
    public int? ZoUniqueNo { get; set; }

    public string? ZoLoginId { get; set; }

    public string? ZoPassword { get; set; }

    public string? ZoDescription { get; set; }

    public int? ZoStyle { get; set; }

    public int? ZoSearchSize { get; set; }

    public int? ZoAuthlistSize { get; set; }
}
