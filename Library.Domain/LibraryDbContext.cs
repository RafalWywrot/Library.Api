using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Library.Domain
{
    public class LibraryDbContext : DbContext
    {
        //dodaj connection stringa do bazy z azure
        public LibraryDbContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
