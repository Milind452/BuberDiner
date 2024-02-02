using Microsoft.AspNetCore.Mvc;

namespace BuberDiner.Api.Controllers;

public class ErrorController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}