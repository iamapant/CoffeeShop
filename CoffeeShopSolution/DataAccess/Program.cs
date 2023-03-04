using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;

namespace DataAccess {
    internal class Program {
        static void Main(string[] args) {
            var context = new CoffeeShopContext();
            Item it = new Item();
            it.ItemName = "Test";
            it.Descr = "Test";
            it.Price = 1;
            it.ItemType = "Test";

            Console.WriteLine(context.Items.Add(it));

            context.SaveChanges();

            var Items = context.Items;
            foreach (var i in Items) {
                Console.WriteLine(i.ItemId);
            }
        }
    }
}