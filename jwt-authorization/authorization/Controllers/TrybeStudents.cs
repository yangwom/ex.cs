using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace authorization.Controllers;

[ApiController]
[Route("[controller]")]
public class TrybeStudentController : ControllerBase
{

    [HttpGet]
    [Authorize(Policy = "TrybeStudent")]
public ActionResult<string> MessageForStudents() 
{
    return "Parabéns pela sua jornada até aqui como pessoa desenvolvedora!";
}

[HttpGet] 
[AllowAnonymous]

public ActionResult<string> MessageForFutereStudants()
{
    return "A porta de entrada para carreira em tecnologia";
}
}
