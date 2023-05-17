using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
		//Metodos Auxiliares para crear Usuarios
		public async Task InsertUsuarios(Tarjeta input)
		{
			var res = await _context.Tarjeta.AddAsync(input);
			var resultaod = await _context.SaveChangesAsync();
			var res1 = _context.Tarjeta.ToList();
		}
		public async Task<Tarjeta> GetUsuario()
		{
			return await _context.Tarjeta.FirstOrDefaultAsync();
		}
		public async Task<List<Tarjeta>> GetUsuarios()
		{
			return await _context.Tarjeta.ToListAsync();
		}
		public async Task<Estado> GetUsuarioByUsuarioTarjetaAsync(long input)
		{
			var tarjeta = await _context.Tarjeta.FirstOrDefaultAsync(x => x.NumeroTarjeta == input);
			if (tarjeta == null)
			{
				return new Estado()
				{
					Mensaje = "Usuario No Encontrado",
					Ok = false,
					NumeroTarjeta = null,
				};
			}
			return new Estado()
			{
				Mensaje = "Usuario Encontrado",
				Ok = true,
				NumeroTarjeta = tarjeta.NumeroTarjeta,
			};
		}
	}
}
