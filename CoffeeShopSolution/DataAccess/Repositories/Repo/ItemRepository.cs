using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Repo {
    public class ItemRepository : IItemRepository {

        private CoffeeShopContext context = new CoffeeShopContext();
        public void AddItem(Item item) {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id) {
            throw new NotImplementedException();
        }

        public Item? GetItemById(int id) => GetItems().SingleOrDefault(i => i.ItemId == id);

        public IEnumerable<Item> GetItems() => context.Items;

        public void UpdateItem(Item item) {
            throw new NotImplementedException();
        }

        public void UpdateStock(int id, int amount, bool isIncrease) {
            throw new NotImplementedException();
        }
    }
}
