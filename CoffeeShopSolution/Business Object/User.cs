using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Object
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string? UserEmail { get; set; }
        public string userPassword { get; set; }
        public List<Item>? UserCart { get; set; }
        public List<Order>? OrderHistory { get; set; }
        public User() { }
    }
}
