using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ContactsAPI.Application.Exceptions;


namespace ContactsAPI.configuration
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            HttpStatusCode status = HttpStatusCode.InternalServerError;
            String message = "Server Error Occurred.";

            var exceptionType = context.Exception.GetType();

            if(exceptionType == typeof(NotImplementedException))
            {
                status = HttpStatusCode.NotImplemented;
                message = "The operation is not implemented.";
            }
            else if(exceptionType == typeof(DuplicateEmailException))
            {
                status = HttpStatusCode.BadRequest;
                message = "Email already exists in the system";
            }
            else if(exceptionType == typeof(DuplicatePhoneNumber))
            {
                status = HttpStatusCode.BadRequest;
                message = "Phone number already exists in the system";
            }
            else if(exceptionType == typeof(NotFoundException))
            {
                status = HttpStatusCode.NotFound;
                message = "resource not found";
            }

            context.ExceptionHandled = true;

            HttpResponse response = context.HttpContext.Response;
            response.StatusCode = (int)status;
            response.ContentType = "application/json";
            var err = message;
            response.WriteAsync(JsonConvert.SerializeObject(err));

        }
    }
}
