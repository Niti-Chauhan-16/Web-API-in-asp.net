using Microsoft.EntityFrameworkCore;
using WebApi.Models;

namespace WebApi.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Students> Students { get; set; }

        public DbSet<Standard> Standards {  get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().HasData(
                new Students { StudentId = 2, FirstName = "niti", LastName="chauhan" }
                
                );
        }
        */

    }
}
