using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delib;

public partial class CiSysHeader
{
    public int? FileNo { get; set; }

    public int? EqNo { get; set; }

    public int? FacNo { get; set; }

    public int? BkUnique { get; set; }

    public int? GroupNo { get; set; }

    public string? SysUser { get; set; }

    public int? BfUnique { get; set; }

    public int? CltUnique { get; set; }

    public int? CtUnique { get; set; }

    public decimal? SysRound { get; set; }

    public string? SysBookfacPrt { get; set; }

    public string? SysBookequipPrt { get; set; }

    public decimal? CiTax { get; set; }
}
