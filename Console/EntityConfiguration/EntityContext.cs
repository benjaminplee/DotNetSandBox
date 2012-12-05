using System.Data.Common;
using System.Data.Entity;
using Console.Entities;

namespace Console.EntityConfiguration
{
    public class EntityContext: DbContext
    {
        public EntityContext(DbConnection connection) : base(connection, false)
        {
            Database.SetInitializer<EntityContext>(null);
        }

        public EntityContext(string connection) : base(connection)
        {
            Database.SetInitializer<EntityContext>(null);
        }

        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
