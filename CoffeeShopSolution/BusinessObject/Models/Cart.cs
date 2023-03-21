using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Cart
{
    public int? UserId { get; set; }

    public int? ItemId { get; set; }

    public int Amount { get; set; }

    public decimal? AddedPrice { get; set; }

    public string? Note { get; set; }

    public virtual Item? ItemIdNavigation { get; set; }

    public virtual User? UserIdNavigation { get; set; }
}
