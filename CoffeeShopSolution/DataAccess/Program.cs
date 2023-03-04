using Microsoft.EntityFrameworkCore;
using BusinessObject.Models;
using DataAccess.Repositories.Repo;

namespace DataAccess
{
    internal class Program {
        static void Main(string[] args) {
            UserRepository repository = new UserRepository();
            //try {
            //    repository.AddUser(new User { UserName = "a", Email = "a@a.a", Password = "a" });
            //}
            //catch (Exception ex) {
            //    if(ex.Message == "User already exists.") Console.WriteLine(ex.Message);
            //}
            //try {
            //    repository.DeleteUser(new User {UserId = 1, UserName = "c", Email = "c@c.c", Password = "c" });
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex);
            //}

            try {
                repository.UpdateUser(new User { UserId = 8,Email="a",Password="b"});
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            //var UserList = repository.GetUsers();
            //foreach (var user in UserList) {
            //    Console.WriteLine(user.UserName);
            //}
            //Console.WriteLine(repository.GetUserById(8).UserId);
        }
    }
}