using Microsoft.EntityFrameworkCore;

namespace ProjectOrigin.EntityFrameworkCore
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

    }
}
