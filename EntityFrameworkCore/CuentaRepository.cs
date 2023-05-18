using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOrigin.EntityFrameworkCore
{
	public class CuentaRepository : ICuentaRepository
	{
		private readonly AppDbContext _context;
		public CuentaRepository(AppDbContext context)
		{
			_context = context;
		}
		public async Task<Balance> GetBalanceAsync(long numeroTarjeta)
		{
			var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroTarjeta == numeroTarjeta);
			if (cuenta == null) return new Balance();

			var balance = new Balance()
			{
				NumeroTarjeta = cuenta.NumeroTarjeta,
				BalanceTotal = cuenta.Balance,
				FechaVencimiento = cuenta.FechaVencimiento
			};
			return balance;
		}
		public async Task<Retiro> GetRetiroAsync(long retiroInput, long numeroTarjeta)
		{
			var cuenta = await _context.Cuenta.FirstOrDefaultAsync(x => x.NumeroTarjeta == numeroTarjeta);
			if (cuenta.Balance - retiroInput < 0)
			{
				return new Retiro()
				{
					DineroRetirado = null,
					OperacionDescripcion = "Operacion Invalida, No cuenta con suficiente dinero",
					OperacionExitosa = false
				};
			}
			cuenta.Balance -= retiroInput;
			await _context.SaveChangesAsync();
			return new Retiro()
			{
				DineroRetirado = retiroInput,
				OperacionDescripcion = "Operacion Exitosa, que tenga buen dia",
				OperacionExitosa = true
			};
		}
	}
}
