using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOrigin.EntityFrameworkCore
{
    public class UsuarioRepository : IUsuarioRepository
	{
		private readonly AppDbContext _context;
		public UsuarioRepository(AppDbContext context)
		{
			_context = context;
		}
		//Metodos Auxiliares para crear Usuarios
		public async Task InsertUsuarios(Usuario input)
		{
			var cuenta = new Cuenta()
			{
				NumeroTarjeta = input.NumeroTarjeta,
				IsBlocked = input.IsBlocked,
				NombreUsuario = input.NombreUsuario,
				Balance = 1000,
				FechaVencimiento = DateTime.Now.AddYears(7)
			};
			await _context.Cuenta.AddAsync(cuenta);
			await _context.Tarjeta.AddAsync(input);
			await _context.SaveChangesAsync();
			var res1 = _context.Tarjeta.ToList();
		}
		public async Task<Usuario> GetUsuario()
		{
			return await _context.Tarjeta.FirstOrDefaultAsync();
		}
		public async Task<List<Usuario>> GetUsuarios()
		{
			return await _context.Tarjeta.ToListAsync();
		}
		public async Task<Estado> GetUsuarioByUsuarioTarjetaAsync(long input)
		{
			await _context.SaveChangesAsync();
			var tarjeta = await _context.Tarjeta.FirstOrDefaultAsync(x => x.NumeroTarjeta == input);
			if (tarjeta == null)
			{
				return new Estado()
				{
					Mensaje = "Usuario No Encontrado",
					UsuarioBloqueado = false,
					Ok = false,
					NumeroTarjeta = null,
				};
			}
			if (tarjeta.IsBlocked)
			{
				return new Estado()
				{
					Mensaje = "Usuario Bloqueado, contactar con servicio tecnico",
					UsuarioBloqueado = false,
					Ok = false,
					NumeroTarjeta = null,
				};
			}
			return new Estado()
			{
				Mensaje = "Usuario Encontrado",
				UsuarioBloqueado = false,
				Ok = true,
				NumeroTarjeta = tarjeta.NumeroTarjeta,
			};
		}

		public async Task<Estado> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN)
		{
			var tarjeta = await _context.Tarjeta.FirstOrDefaultAsync(x => x.NumeroTarjeta == numeroTarjeta);
			if (tarjeta.PIN != PIN)
			{
				tarjeta.Count++;
				await _context.SaveChangesAsync();
				if (tarjeta.Count >= 4)
				{
					tarjeta.IsBlocked = true;
					await _context.SaveChangesAsync();
					return new Estado()
					{
						Mensaje = "Usuario Bloqueado, contactar con servicio tecnico",
						UsuarioBloqueado = true,
						Ok = false,
						NumeroTarjeta = null,
					};
				}
				return new Estado()
				{
					Mensaje = $"PIN incorrecto, volver a intentar, intento Numero {tarjeta.Count} le quedan {4 - tarjeta.Count} intentos mas",
					UsuarioBloqueado = false,
					Ok = false,
					NumeroTarjeta = null,
				};
			}
			return new Estado()
			{
				Mensaje = $"Usuario Validado, Bienvenido {tarjeta.NombreUsuario}",
				UsuarioBloqueado = false,
				Ok = true,
				NumeroTarjeta = tarjeta.NumeroTarjeta,
			};
		}
	}
}
