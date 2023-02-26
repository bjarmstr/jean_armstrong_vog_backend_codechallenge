using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;
using VogCodeChallenge.Shared.Exceptions;

namespace VogCodeChallenge.API.Restful.Middleware
{
    public class GlobalExceptionHandler
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
        
            try
            {
                await _next(context);
            }
            catch (Exception err)
            {
                // catches unhandled exceptions in the pipeline

                  var response = context.Response;
                response.ContentType = "application/json";
                string errorMessage;

                switch (err)
                {
                    case BadRequestException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        errorMessage = e.Message;
                        break;
                    case NotFoundException e: 
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        errorMessage = e.Message;
                        break;
                   default: // unknown error - return a formatted response
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        errorMessage = "Default Exception: " + err.Message;
                        break;
                }

                // Return the response
                var result = JsonSerializer.Serialize(new { message = errorMessage });
                await response.WriteAsync(result);
            }
        }
    }
}

