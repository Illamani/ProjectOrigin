using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Models;

namespace ProjectOrigin.EntityFrameworkCore
{
	public class AppDbContext : DbContext
	{

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

        public DbSet<Tarjeta> Tarjeta { get; set; }
    }
}
