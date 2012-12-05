using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Console.Entities;

namespace Console.EntityConfiguration
{
    internal class CustomerConfiguration : EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {
            HasKey(c => c.Id);

            Property(p => p.Id).
                HasColumnName("id").
                HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).
                IsRequired();

            Property(p => p.Name).
                HasColumnName("name").
                IsRequired();

            ToTable("customer");
        }
    }
}