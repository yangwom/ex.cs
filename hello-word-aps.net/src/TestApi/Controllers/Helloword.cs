using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloWordController
{
    [HttpGet]
    public string Get() => "Hello Word";
    [HttpGet]
    [Route("2")]
    public string  GetHelloTrybe()
    {
  
   
     return "Hello tryber";
    }
}
