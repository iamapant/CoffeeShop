using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories {
    public class UserRepository : IUserRepository {
        public void AddUser(User user) {
            if (user == null) {
                throw new Exception("Input user is null.");
            }
            else {
                if (user.UserName == null) throw new Exception("Username must not be empty.");
                else if (user.Password == null) throw new Exception("Password must not be empty.");
                else if (user.Email == null) throw new Exception("E-mail nust not be empty.");
                CoffeeShopContext context = new CoffeeShopContext();
                try {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch (Exception ex) {
                    throw new Exception("User already exists.");
                }
            }
        } 

        public void DeleteUser(User user) {
            if (user == null) {
                throw new Exception("Input user is null.");
            }
            else {
                CoffeeShopContext context = new CoffeeShopContext();
                try {
                    if (context.Users.SingleOrDefault(u => u == user) != null) {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    else throw new Exception("User not found.");
                }
                catch (Exception ex) {
                    if(ex.InnerException!= null) {
                        throw new Exception("New Exception:\n\n\n "+ex.Message);
                    }
                    throw new Exception(ex.Message);
                }
            }
        }

        public User? GetUserById(int id) => new CoffeeShopContext().Users.Find(id);

        public User? GetUserByLogin(string username, string password) => new CoffeeShopContext().Users.SingleOrDefault(u => u.UserName == username && u.Password == password);

        public IEnumerable<User> GetUsers() => new CoffeeShopContext().Users;

        public void UpdateUser(User user) {
            if (user == null) {
                throw new Exception("Input user is null.");
            }
            else {
                if (user.UserName == null) throw new Exception("Username must not be empty.");
                else if (user.Password == null) throw new Exception("Password must not be empty.");
                else if (user.Email == null) throw new Exception("E-mail nust not be empty.");
                CoffeeShopContext context = new CoffeeShopContext();
                try {
                    if (GetUserById(user.UserId) != null) {
                        context.Users.Update(user);
                        context.SaveChanges();
                    }
                    else throw new Exception("User not found.");

                }
                catch(Exception ex) {
                    if (ex.InnerException != null) {
                        throw new Exception("Inner \n\n\n: " + ex.Message);
                    }
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
