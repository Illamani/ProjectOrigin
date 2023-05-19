using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Entities;
using System;
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
		public async Task InsertDineroACuenta(double insertInput, long numeroTarjeta)
		{
			var cuenta = await _context.Cuenta.Include(x => x.Registros).FirstOrDefaultAsync(x => x.NumeroTarjeta == numeroTarjeta);
			cuenta.Balance += insertInput;
			await _context.SaveChangesAsync();
		}
		public async Task<Balance> GetBalanceAsync(long numeroTarjeta)
		{
			var cuenta = await _context.Cuenta.Include(x => x.Registros).FirstOrDefaultAsync(x => x.NumeroTarjeta == numeroTarjeta);
			if (cuenta == null) return new Balance();

			var balance = new Balance()
			{
				NumeroTarjeta = cuenta.NumeroTarjeta,
				BalanceTotal = cuenta.Balance,
				FechaVencimiento = cuenta.FechaVencimiento
			};
			return balance;
		}
		public async Task<Retiro> GetRetiroAsync(double retiroInput, long numeroTarjeta)
		{
			var cuenta = await _context.Cuenta.Include(x => x.Usuario).FirstOrDefaultAsync(x => x.NumeroTarjeta == numeroTarjeta);
			if(cuenta == null) return null;
			if (cuenta.Balance - retiroInput < 0)
			{
				return new Retiro()
				{
					DineroRetirado = null,
					OperacionDescripcion = "Operacion Invalida, No cuenta con suficiente dinero",
					OperacionExitosa = false
				};
			}
			var registro = new Registros()
			{
				NumeroTarjeta = cuenta.NumeroTarjeta,
				CodigoOperacion = 1,
				OperacionTiempo = DateTime.Now,
			};
			_context.Registros.Add(registro);
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
