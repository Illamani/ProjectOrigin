using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Dto;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOrigin.EntityFrameworkCore
{
	public class CajeroRepository : ICajeroRepository
	{
		private readonly AppDbContext _context;
		public CajeroRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task InsertUsuarios(Tarjeta input)
		{
			await _context.Tarjeta.AddAsync(input);
		}
		public async Task<Tarjeta> GetTarjeta()
		{
			return await _context.Tarjeta.FirstOrDefaultAsync();
		}
	}
}
