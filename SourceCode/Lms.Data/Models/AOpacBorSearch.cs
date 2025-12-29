using System;
using System.Collections.Generic;

namespace Lms.Data.Models;

public partial class AOpacBorSearch
{
    public int SearchId { get; set; }

    public int BorNo { get; set; }

    public string? ShortDescription { get; set; }

    public string? LlCode { get; set; }

    public string? StkForm { get; set; }

    public string? StkGroup { get; set; }

    public string? StkCode { get; set; }

    public string? StkIsOnLoan { get; set; }

    public string? StkIsOnOrder { get; set; }

    public int? StkIsReserved { get; set; }

    public string? CatOrderColumn { get; set; }

    public int? QuantityResult { get; set; }

    public virtual ICollection<AOpacBorSearchCatFilter> AOpacBorSearchCatFilters { get; set; } = new List<AOpacBorSearchCatFilter>();

    public virtual ICollection<AOpacBorSearchDefinition> AOpacBorSearchDefinitions { get; set; } = new List<AOpacBorSearchDefinition>();
}
