using Deloitte.Portal.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Deloitte.Portal.API.Controllers
{
    //[Route("api/[controller]")]
    [AllowAnonymous]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class ErrorsController : ControllerBase
    {
        //[Route("error")]
        //public CustomErrorResponse Error()
        //{
        //    var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
        //    var exception = context.Error; // Your exception
        //    var code = 500; // Internal Server Error by default

        //    if (exception is MyNotFoundException) code = 404; // Not Found
        //    else if (exception is MyUnauthException) code = 401; // Unauthorized
        //    else if (exception is MyException) code = 400; // Bad Request

        //    Response.StatusCode = code; // You can use HttpStatusCode enum instead

        //    return new CustomErrorResponse(exception); // Your error model
        //}
    }
}
