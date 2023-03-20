using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Repo {
    public class UserRepository : IUserRepository {

        private CoffeeShopContext context = new CoffeeShopContext();
        public IEnumerable<User> GetUsers() => context.Users;

        public User? GetUserById(int id) => context.Users.Find(id);

        public User? GetUserByLogin(string username, string password) {
            if(username == context.admin.UserName) {
                if(password == context.admin.Password) return context.admin;
                else return null;
            }
            return context.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }

        public void AddUser(User user) {
            if (user == null) throw new Exception("Input user is null.");
            else {
                if (user.UserName == null) throw new Exception("Username must not be empty.");
                if (user.Password == null) throw new Exception("Password must not be empty.");
                else if (user.Email == null) throw new Exception("E-mail must not be empty.");
                if (user.UserName == context.admin.UserName || user.Email == context.admin.UserName) throw new Exception("Username must not be 'admin'.");
                try {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch (Exception ex) {
                    throw new Exception(ex.InnerException.Message);
                }
            }
        }

        public void DeleteUser(User user) {
            if (user == null) throw new Exception("Input user is null.");
            else {
                try {
                    if (context.Users.SingleOrDefault(u => u == user) != null) {
                        context.Users.Remove(user);
                        context.SaveChanges();
                    }
                    else throw new Exception("User not found.");
                }
                catch (Exception ex) {
                    if (ex.InnerException != null) {
                        throw new Exception("New Exception:\n\n\n " + ex.Message);
                    }
                    throw new Exception(ex.Message);
                }
            }
        }

        public void UpdateUser(User user) {
            if (user == null) throw new Exception("Input user is null.");
            else {
                //check for null
                if (user.UserName == null) throw new Exception("Username must not be empty.");
                else if (user.Password == null) throw new Exception("Password must not be empty.");
                else if (user.Email == null) throw new Exception("E-mail nust not be empty.");
                //check for changes
                if (user.UserName.Equals(GetUserById(user.UserId).UserName) && user.Password.Equals(GetUserById(user.UserId).Password) &&
                    user.Email.Equals(GetUserById(user.UserId).Email)) throw new Exception("No changes occurs.");
                try {
                    if (GetUserById(user.UserId) != null) {
                        context.Users.Update(user);
                        context.SaveChanges();
                    }
                    else throw new Exception("User not found.");
                }
                catch (Exception ex) {
                    if (ex.InnerException != null) {
                        throw new Exception("Inner \n\n\n: " + ex.Message);
                    }
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
