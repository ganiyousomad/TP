using Back_End.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_End.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Value> values { get; set; }
    }
}
