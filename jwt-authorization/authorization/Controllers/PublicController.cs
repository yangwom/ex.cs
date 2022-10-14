using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Trybe.controller;

[Route("api")]
[AllowAnonymous]
[ApiController]

public class PublicController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> MessageForFutureStudents()
    {
        return "A porta de entrada para sua carreira em tecnologia";
    }

    [HttpGet]
    public ActionResult<string> MessageForFutureStudentsTwo()
    {
        return "90% das pessoas formadas já estão trabalhando em até 3 meses após a formatura.";
    }

}