using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public int? Phone { get; set; }

    public string? Address { get; set; }

    public DateTime? Odate { get; set; }

    public decimal Total { get; set; }

    public virtual User? UserIdNavigation { get; set; }
}
