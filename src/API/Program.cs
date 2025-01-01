using Scalar.AspNetCore;

namespace API;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddOpenApiDocument();
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
		app.Run();
	}
}