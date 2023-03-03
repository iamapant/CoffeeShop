using Business_Object;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserDBContext
    {
        private static UserDBContext instance = null;
        public static readonly object instanceLock = new object();
        private UserDBContext() { }
        public static UserDBContext Instance
        {
            get { 
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDBContext();
                    }
                }
                return instance; 
            }
        }

        private static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConnection = config["ConnectionStrings:CoffeeDB"];
            return strConnection;
        }

        public List<User> GetUsersList()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection conn = factory.CreateConnection();
            if(conn == null)
            {
                Console.WriteLine(@"Unable to create connection object.");
                return null;
            }
            conn.ConnectionString = GetConnectionString();
            conn.Open();

            DbCommand com = factory.CreateCommand();
            com.Connection = conn;
            com.CommandText = "select "
        }
    }
}
