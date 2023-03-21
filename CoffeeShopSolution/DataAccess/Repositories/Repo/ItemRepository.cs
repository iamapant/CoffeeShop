using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Repo {
    public class ItemRepository : IItemRepository {

        private CoffeeShopContext context = new CoffeeShopContext();
        public void AddItem(Item item) {
            if (item == null) throw new Exception("Input item is null");
            if (item.ItemName == null) throw new Exception("Item name must not be empty.");
            else {
                try {
                    context.Items.Add(item);
                    context.SaveChanges();
                }
                catch (Exception ex) {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void DeleteItem(int id) {
            if (id == null) throw new Exception("Input id is null");
            if (context.Items.SingleOrDefault(i => i.ItemId == id) == null) throw new Exception("Cannot find item to delete.");
            try {
                context.Items.Remove(GetItemById(id));
                context.SaveChanges();
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public Item? GetItemById(int id) => context.Items.SingleOrDefault(i => i.ItemId == id);

        public IEnumerable<Item> GetItems() => context.Items;

        public void UpdateItem(Item item) {
            if (item == null) throw new Exception("Input item is empty.");
            else {
                if (item.ItemName == null) throw new Exception("Item name must not be empty.");
                else if (item.Price == null) throw new Exception("Item price must not be empty");
                else if (item.Stock == null) throw new Exception("Item stock must not be empty.");
                try {
                    context.Items.Update(item);
                    context.SaveChanges();
                }
                catch (Exception ex) {
                    throw new Exception(ex.Message);
                }
            }
        }

        public void UpdateStock(int id, int amount, bool isIncrease) {
            int bit = 0;
            if (isIncrease) bit = 1; 
            if (GetItemById(id) == null) throw new Exception("Item does not exist.");

            var outs = context.Database.SqlQuery<int>($"exec changeStock_Item @iid = {id},@amount = {amount}, @isAdd = {bit}").ToList();
            if(outs.Count == 0) {
                throw new Exception($"Unable to change stock. Item {id}'s stock is too low.");
            }
        }
    }
}
