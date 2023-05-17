﻿using AutoMapper;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Services
{
	public class CajeroService : ICajeroService
	{
        private readonly IMapper _mapper;
        private readonly ICajeroRepository _cajeroRepository;
        public CajeroService(IMapper mapper, ICajeroRepository cajeroRepository)
		{
			_mapper = mapper;
			_cajeroRepository = cajeroRepository;
		}
		public async Task InsertUsuarios(TarjetaDto input)
        {
            var tarjeta = _mapper.Map<TarjetaDto, Tarjeta>(input);
			await _cajeroRepository.InsertUsuarios(tarjeta);
        }
		public async Task<TarjetaDto> GetUsuario()
		{
			var tarjeta = await _cajeroRepository.GetUsuario();
			return _mapper.Map<Tarjeta,TarjetaDto>(tarjeta);
		}
		public async Task<List<TarjetaDto>> GetUsuarios()
		{
			var tarjetaList = await _cajeroRepository.GetUsuarios();
			return _mapper.Map<List<Tarjeta>, List<TarjetaDto>>(tarjetaList);
		}
		public async Task<EstadoDto> GetUsuarioByUsuarioTarjetaAsync(long input)
		{
			var tarjeta = await _cajeroRepository.GetUsuarioByUsuarioTarjetaAsync(input);
			return _mapper.Map<Estado, EstadoDto>(tarjeta);
		}
		public async Task<EstadoDto> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN)
		{
			var acceso = await _cajeroRepository.GetAccessByUsuarioAsync(numeroTarjeta, PIN);
			return _mapper.Map<Estado, EstadoDto>(acceso);
		}
	}
}
