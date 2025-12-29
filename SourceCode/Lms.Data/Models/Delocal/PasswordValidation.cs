using System;
using System.Collections.Generic;

namespace Lms.Data.Models.Delocal;

public partial class PasswordValidation
{
    public int Id { get; set; }

    public string UserType { get; set; } = null!;

    public int ValidId { get; set; }

    public int? LibGroupId { get; set; }

    public int? ValidIdValue { get; set; }
}
