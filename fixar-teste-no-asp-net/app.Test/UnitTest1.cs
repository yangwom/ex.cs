namespace app.Test;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using FluentAssertions;
 using System.Threading.Tasks;
public class UnitTest1
{
    [Fact]
    public async Task InitialTest()
{
    var application = new WebApplicationFactory<Program>()
        .WithWebHostBuilder(builder =>
        {
            // ... Configurações do teste de integração
        });

    // Criação do cliente
    var client = application.CreateClient();    
}
}

public class TestWeatherForecast : IClassFixture<WebApplicationFactory<Program>>
{

    private readonly WebApplicationFactory<Program> _factory;

    public TestWeatherForecast(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory(DisplayName = "WeatherForecast deve responder com status com 200 ~ 299 para rotas")]    
    [InlineData("/weatherforecast")]
    public async Task GetEndpointsReturnSuccess(string url)
    {        
        var client = _factory.CreateClient();
        var response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        response.Content.Headers.ContentType.ToString().Should().Be("application/json; charset=utf-8");
    }
}