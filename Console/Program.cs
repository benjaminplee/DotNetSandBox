using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using Console.EntityConfiguration;

namespace Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string connectionString = @"Provider=System.Data.SQLite;data source=db\database.sqlite";

            using (var conn = new SQLiteConnection(connectionString))
            {
//                conn.Open();

                using (var context = new EntityContext(connectionString))
                {
                    var customers = context.Customers.ToList();

                    foreach (var customer in customers)
                    {
                        System.Console.WriteLine("Customer (Id: {0}, Name:{1}", customer.Id, customer.Name);
                    }
                }
            }
        }
    }
}