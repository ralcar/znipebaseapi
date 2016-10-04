using Microsoft.EntityFrameworkCore;

namespace ZnipeBaseApi
{
    public class ZnipeBaseDbContext : DbContext
    {
        public ZnipeBaseDbContext(DbContextOptions options) : base(options)
        {
        }

        public ZnipeBaseDbContext() {}

        public DbSet<ObserverMachine> ObserverMachines { get; set; }
    }

    public class ObserverMachine
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
