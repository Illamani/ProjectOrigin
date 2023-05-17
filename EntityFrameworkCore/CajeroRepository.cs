using System.Linq;

namespace ProjectOrigin.EntityFrameworkCore
{
	public class CajeroRepository
	{
		private readonly AppDbContext _context;
		public CajeroRepository(AppDbContext context)
		{
			_context = context;
		}

		public int GetInformacionBaseDeDatos()
		{
			var dbContext = _context.Tarjeta.FirstOrDefault().
		}
	}
}
