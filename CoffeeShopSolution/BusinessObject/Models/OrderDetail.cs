using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class OrderDetail
{
    public int? OrderId { get; set; }

    public int? ItemId { get; set; }

    public int? Amount { get; set; }

    public string? Note { get; set; }

    public DateTime? OrderDate { get; set; }

    public virtual Item? ItemIdNavigation { get; set; }

    public virtual Order? OrderIdNavigation { get; set; }
}
