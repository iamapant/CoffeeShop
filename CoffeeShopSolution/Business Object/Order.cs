using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class Order
    {
        public int OrderId { get; set; }
        public User? OrderUser { get; set; }
        public List<Item>? OrderItems { get; set; }
        public Order() { }
    }
}
