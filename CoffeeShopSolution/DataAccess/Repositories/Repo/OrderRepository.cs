using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Repo {
    internal class OrderRepository : IOrderRepository {

        private CoffeeShopContext context = new CoffeeShopContext();

        public void AddNewOrder(int id) {
            if (id == null) throw new Exception("Input Id is empty.");
            else if (new UserRepository().GetUserById(id) == null) throw new Exception("User not found.");
            if (new CartRepository().GetCartByUserId(id) == null) throw new Exception("User's cart is empty.");
            try {
                var outs = context.Database.SqlQuery<int>($"exec insert_Order @uid = {id}").ToList();
                if (outs.Count < 1) throw new Exception(outs.Count + " line(s) was changed.");
                else if (outs.Count > 1) throw new Exception("WTF: " + outs.Count);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public IEnumerable<Order> GetOrders() => context.Orders;

        public IEnumerable<Order> GetOrdersByUserId(int id) => context.Orders.Where(o => o.UserId == id);

        public int GetOrdersCountByUserId(int id) => GetOrdersByUserId(id).Count();

        public IEnumerable<OrderDetail> GetOrdersDetail() => context.OrderDetails;

        public IEnumerable<OrderDetail> GetOrdersDetailByOrderId(int OrderId) => context.OrderDetails.Where(o => o.OrderId == OrderId);

        public decimal GetOrderTotal(int OrderId) => ((Order)context.Orders.Where(o => o.OrderId == OrderId)).Total;
    }
}
