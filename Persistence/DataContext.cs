
using Domain;
using Microsoft.EntityFrameworkCore;


namespace Persistence
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Activity1> Activities { get; set; }
    }
}