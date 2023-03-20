using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class ShippingInfo
{
    public int Id { get; set; }

    public int? Phone { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public virtual User IdNavigation { get; set; } = null!;
}
