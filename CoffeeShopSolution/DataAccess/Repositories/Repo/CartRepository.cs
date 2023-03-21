using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Repo {
    public class CartRepository : ICartRepository {
        private CoffeeShopContext context = new CoffeeShopContext();
        public void AddCartItem(int UserId, int ItemId, int amount, string? note, int price) {
            //Check Null
            if (UserId == null) throw new Exception("Input User Id is empty.");
            if (ItemId == null) throw new Exception("Input Item Id is empty.");
            if (amount == null || amount <= 0) throw new Exception("Invalid amount");
            if (note == null) note = "";
            //Check Exist
            if (new UserRepository().GetUserById(UserId) == null) throw new Exception("User not found.");
            if (new ItemRepository().GetItemById(ItemId) == null) throw new Exception("Item not found.");
            try {
                var outs = context.Database.SqlQuery<int>($"exec insert_Cart @uid = {UserId} ,@iid = {ItemId} ,@add = {amount} , @note = {note}, @price = {price}").ToList();
                if (outs.Count < 1) {
                    throw new Exception(outs.Count() + " line(s) changed. Amount want to be add may exceed limit");       //NEED WORK?
                }
                if (outs.Count > 1) {
                    throw new Exception(outs.Count() + " mismatch.");       //NEED WORK?
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCartItem(int UserId, int ItemId, int amount, string? note) {
            //Check Null
            if (UserId == null) throw new Exception("Input User Id is empty.");
            if (ItemId == null) throw new Exception("Input Item Id is empty.");
            if (amount == null || amount <= 0) throw new Exception("Invalid amount");
            if (note == null) note = "";
            //Check Exist
            if (new UserRepository().GetUserById(UserId) == null) throw new Exception("Invalid UserId.");
            if (new ItemRepository().GetItemById(ItemId) == null) throw new Exception("Invalid Item.");
            try {
                var outs = context.Database.SqlQuery<int>($"exec delete_Cart @uid = {UserId} ,@iid = {ItemId} ,@add = {amount} , @note = {note}").ToList();
                if (outs.Count < 1) {
                    throw new Exception(outs.Count() + " line(s) changed. Amount want to be deleted may exceed limit");       //NEED WORK?
                }
                if (outs.Count > 1) {
                    throw new Exception(outs.Count() + " mismatch.");       //NEED WORK?
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        public IEnumerable<Cart> GetCartByUserId(int id) => context.Carts.Where(c => c.UserId == id);

        public IEnumerable<Cart> GetCarts() => context.Carts;
    }
}
