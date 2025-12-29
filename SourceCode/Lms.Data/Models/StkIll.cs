using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class StkIll
{
    public string? StiItemNo { get; set; }

    public string? StiSupp1Code { get; set; }

    public string? StiSupp2Code { get; set; }

    public string? StiSupp3Code { get; set; }

    public DateTime? StiDatelast { get; set; }

    public string? StiLocCode { get; set; }

    public string? StiOper { get; set; }

    public DateTime? StiStatusdate { get; set; }

    public string? StiStatus { get; set; }

    public string? StiBorBarNo { get; set; }

    public string? StiBorName { get; set; }

    public string? StiComment { get; set; }

    public string? StiLocDesc { get; set; }

    public string? StiColl { get; set; }

    public string? StiCollDesc { get; set; }

    public int StiUniqueNo { get; set; }

    public decimal? StiIllsCost { get; set; }

    public string? StiIllsCode { get; set; }
}
