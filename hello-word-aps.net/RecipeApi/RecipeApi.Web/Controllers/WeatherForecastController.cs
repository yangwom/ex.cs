using Microsoft.AspNetCore.Mvc;
using JsonFlatFileDataStore;

namespace RecipeApi.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public class RecipeController : ControllerBase
{
    private readonly IDataStore _db;

    public RecipeController(IDataStore db)
    {
        _db = db;
    }
}

}

