﻿using Microsoft.AspNetCore.Mvc;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Controllers
{
	public class CuentaController : ControllerBase, ICuentaService
	{
        private readonly ICuentaService _cuentaService;
        public CuentaController(ICuentaService cuentaService)
        {
            _cuentaService = cuentaService;
        }
		[HttpGet]
		[Route("GetPrueba")]
		public int Get()
		{
			return 123;
		}
		[HttpGet]
		[Route("GetBalanceAsync")]
		public async Task<BalanceDto> GetBalanceAsync(long inputNumeroCuenta)
		{
			return await _cuentaService.GetBalanceAsync(inputNumeroCuenta);
		}

		[HttpGet]
		[Route("GetRetiroAsync")]
		public async Task<RetiroDto> GetRetiroAsync(double retiro, long numeroTarjeta)
		{
			return await _cuentaService.GetRetiroAsync(retiro, numeroTarjeta);
		}
		[HttpPut]
		[Route("InsertDineroACuenta")]
		public async Task InsertDineroACuenta(double insertInput, long numeroTarjeta)
		{
			await _cuentaService.InsertDineroACuenta(insertInput, numeroTarjeta);
		}
	}
}
