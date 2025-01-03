using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;
using Infrastructure.Persistence.Data;
using Infrastructure.Identity.Data;

namespace API;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddOpenApiDocument();
		builder.Configuration.AddEnvironmentVariables();
		builder.Services.AddDbContext<ApplicationDbContext>(options =>
			options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));
		builder.Services.AddDbContext<ApplicationIdentityDbContext>(options =>
			options.UseNpgsql(builder.Configuration.GetConnectionString("Default")));
		builder.Services.AddControllers();
		var app = builder.Build();
		if (app.Environment.IsDevelopment())
		{
			app.UseOpenApi(options =>
			{
				options.Path = "/openapi/{documentName}.json";
			});
			app.MapScalarApiReference(options =>
			{
				options.Title = "Setka API";
			});
		}
		app.UseHttpsRedirection();
		app.MapControllers();
		app.Run();
	}
}