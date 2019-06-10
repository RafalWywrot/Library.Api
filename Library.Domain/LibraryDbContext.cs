using Library.Domain.Entities;
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
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PublishHouse> PublishHouses { get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}
