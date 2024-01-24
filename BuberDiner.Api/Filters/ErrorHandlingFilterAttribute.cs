using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDiner.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        context.Result = new ObjectResult(new
        {
            error = "An error occurred while processing your request.",
            message = exception.Message
        })
        { StatusCode = 500 };
        context.ExceptionHandled = true;
    }
}