using Microsoft.EntityFrameworkCore;
using Productos.Models;

namespace Productos.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }

    }
}
