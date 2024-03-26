using Microsoft.AspNetCore.Mvc;

namespace RecipeBook.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class WeatherForecastController( ILogger<WeatherForecastController> logger, IConfiguration configuration ) : ControllerBase {
	private static readonly string[] Summaries = new[]
	{
		"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
	};

	private readonly ILogger<WeatherForecastController> _logger = logger;
	private readonly IConfiguration configuration = configuration;

	[HttpGet(Name = "GetWeatherForecast")]
	public IEnumerable<WeatherForecast> Get() {
		int n = 3;
		Console.WriteLine($"Hello, forecasting for {n} days.");
		return Enumerable.Range(1, n).Select(index => new WeatherForecast {
			Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			TemperatureC = Random.Shared.Next(-20, 55),
			Summary = Summaries[Random.Shared.Next(Summaries.Length)]
		})
		.ToArray();
	}

	[HttpGet("apikey")]
	public string GetApiKey() {
		Console.WriteLine("Getting API key.");
		return configuration.GetValue<string>("ApiKey");
	}
}
