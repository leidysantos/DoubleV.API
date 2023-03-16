using DoubleV.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DoubleV.API.Data
{
    public class DoubleVDbContext : DbContext
    {
        public DoubleVDbContext(DbContextOptions options) : base(options)
        {
        }

        protected DoubleVDbContext()
        {
        }

        public DbSet<Person> Personas { get; set; }
    }
}
