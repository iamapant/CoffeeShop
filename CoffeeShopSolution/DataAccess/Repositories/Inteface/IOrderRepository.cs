using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Inteface {
    internal interface IOrderRepository {
        IEnumerable<Order> GetOrders();
        IEnumerable<OrderDetail> GetOrdersDetail();
        IEnumerable<Order> GetOrdersByUserId(int id);
        IEnumerable<OrderDetail> GetOrdersDetailByOrderId(int OrderId);
        decimal GetOrderTotal(int OrderId);
        int GetOrdersCountByUserId(int id);
        void AddNewOrder(int id);

    }
}
