using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Inteface {
    public interface IItemRepository {
        IEnumerable<Item> GetItems();
        Item? GetItemById(int id);
        void AddItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int id);
        void UpdateStock(int id, int amount, bool isIncrease);
    }
}
