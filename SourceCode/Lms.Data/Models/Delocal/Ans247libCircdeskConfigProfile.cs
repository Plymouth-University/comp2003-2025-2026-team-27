using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class Ans247libCircdeskConfigProfile
{
    public int ConfigId { get; set; }

    public string SearchByName { get; set; } = null!;

    public string SearchByBarcode { get; set; } = null!;

    public string SearchByDob { get; set; } = null!;

    public string DisplayUserid { get; set; } = null!;

    public string DisplayCharges { get; set; } = null!;

    public string DisplayReservations { get; set; } = null!;

    public string DisplayDob { get; set; } = null!;

    public string DisplayStatus { get; set; } = null!;

    public string DisplayGender { get; set; } = null!;

    public string DisplayRefs { get; set; } = null!;

    public string DisplayLibrary { get; set; } = null!;

    public string DisplayEmail { get; set; } = null!;

    public string DisplayMobileno { get; set; } = null!;

    public string ForegroundColour { get; set; } = null!;

    public string BackgroundColour { get; set; } = null!;

    public string ButtonColor { get; set; } = null!;

    public string BoxColor { get; set; } = null!;

    public string TextColor { get; set; } = null!;

    public int ProfileId { get; set; }

    public virtual AnsProfile Profile { get; set; } = null!;
}
