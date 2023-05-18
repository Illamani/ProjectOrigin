using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProjectOrigin.EntityFrameworkCore;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models.Dto;
using ProjectOrigin.Models;
using ProjectOrigin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectOrigin
{
	public class Startup
	{
		private readonly string _MyCors = "Cors";
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddScoped<IUsuarioService, UsuarioService>();
			services.AddScoped<IUsuarioRepository, UsuarioRepository>();
			services.AddScoped<ICuentaRepository, CuentaRepository>();
			services.AddScoped<ICuentaService, CuentaService>();
			services.AddDbContextPool<AppDbContext>(
				options => options.UseSqlServer(Configuration.GetConnectionString("OriginConnection")));
			services.AddControllers();
			services.AddCors(options =>
			{
				options.AddPolicy(name: _MyCors, builder =>
				{
					builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
				});
			});
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectOrigin", Version = "v1" });
			});
			var mapperConfig = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile(new ProjectOrigin.Models.Mapper());
				//cfg.CreateMap<TarjetaDto, Tarjeta>();
				//cfg.CreateMap<EstadoDto, Estado>();
			});
			IMapper mapper = mapperConfig.CreateMapper();
			services.AddSingleton(mapper);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectOrigin v1"));
			}

			app.UseHttpsRedirection();

			app.UseRouting();
			app.UseCors(_MyCors);
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllers();
			});
		}
	}
}
