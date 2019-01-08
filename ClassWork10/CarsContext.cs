using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ClassWork10
{
    public class CarsContext : DbContext

    {
        public CarsContext() : base("CarsContext")
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Address> Adresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
