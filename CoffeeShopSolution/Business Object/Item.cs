using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class Item
    {   
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string? ItemDescription { get; set; }
        public string? ItemType { get; set; }
        public double ItemPrice { get; set; }
        public int ItemStock { get; set; }
    }
}
