using Microsoft.EntityFrameworkCore;

namespace Kolokwium_2.Models
{
    public class Class1 : DbContext
    {
        public Class1(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
