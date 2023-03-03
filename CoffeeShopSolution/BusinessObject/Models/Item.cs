using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Item
{
    public int ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string? Descr { get; set; }

    public string? ItemType { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }
}
