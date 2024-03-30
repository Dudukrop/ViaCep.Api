
using Refit;
using ViaCep.Api.Integration;
using ViaCep.Api.Integration.Interfaces;
using ViaCep.Api.Integration.Refit;

namespace ViaCep.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddScoped<IViaCepIntegrationService, ViaCepIntegrationService>();

			builder.Services.AddRefitClient<IViaCepIntegrationRefit>().ConfigureHttpClient(c =>
			c.BaseAddress = new Uri("https://viacep.com.br"));

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}