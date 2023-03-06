using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repositories.Repo;

namespace DataAccess
{
    internal class Program {
        static void Main(string[] args) {
            UserRepository Urepository = new UserRepository();
            //try {
            //    repository.AddUser(new User { UserName = "c", Email = "c@a.a", Password = "c" });
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //try {
            //    repository.DeleteUser(new User { UserId = 1, UserName = "c", Email = "c@c.c", Password = "c" });
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //}

            //try {
            //    User u = repository.GetUserById(1);
            //    u.UserName = "b";
            //    repository.UpdateUser(u);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //var UserList = repository.GetUsers();
            //foreach (var user in UserList) {
            //    Console.WriteLine(user.UserName);
            //}
            //Console.WriteLine(repository.GetUserById(1).UserId);


            ItemRepository Irepository = new ItemRepository();
            //try {
            //    Item item1 = new Item { ItemName = "a", Price = 5, Stock = 5 };
            //    Item item2 = new Item { ItemName = "b", Price = 5, Stock = 5 };
            //    Item item3 = new Item { ItemName = "c", Price = 5, Stock = 5 };
            //    Irepository.AddItem(item1);
            //    Irepository.AddItem(item2);
            //    Irepository.AddItem(item3);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //try {
            //    Irepository.UpdateStock(4, 1, false);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //var ItemList = Irepository.GetItems();
            //foreach (var item in ItemList) {
            //    Console.WriteLine("ID: " + item.ItemId + "\tName: " + item.ItemName + "\tPrice: " + item.Price + "\tStock: " + item.Stock);
            //}


            CartRepository Crepository = new CartRepository();
            //try {
            //    Crepository.AddCartItem(1, 1, 7, null);
            //    Crepository.AddCartItem(1, 2, 3, "hello");
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}

            //var CartList = Crepository.GetCarts();
            //foreach (var cart in CartList) {
            //    Console.WriteLine("ID: " + cart.UserId + "\tItem: " + cart.ItemId + "\tAmount: " + cart.Amount + "\tNote: " + cart.Note);
            //}


            OrderRepository Orepository = new OrderRepository();
            //try {
            //    Orepository.AddNewOrder(1);
            //}
            //catch (Exception ex) { 
            //    Console.WriteLine(ex.Message);
            //}
            var OrderList = Orepository.GetOrdersByUserId(1);
            //foreach (var order in OrderList) {
            //    var detail = Orepository.GetOrdersDetailByOrderId(order.OrderId);
            //    Console.WriteLine("OID: " + order.OrderId + "\tAmount: "+order.Total);
            //}
            //var Details = Orepository.GetOrdersDetailByOrderId(OrderList.Last().OrderId);
            //foreach (var detail in Details) {
            //    Console.WriteLine("OrderID: "+detail.OrderId+"\tItemID: "+detail.ItemId+"\tAmount: "+detail.Amount+"\tDate: "+detail.OrderDate);
            //}

        }
    }
}