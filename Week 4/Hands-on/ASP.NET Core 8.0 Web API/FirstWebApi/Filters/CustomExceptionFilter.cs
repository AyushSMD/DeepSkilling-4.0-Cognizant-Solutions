using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace FirstWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = $"Exception: {context.Exception.Message} at {DateTime.Now}\n";

            File.AppendAllText("error_log.txt", message);

            context.Result = new ObjectResult("An error occurred. Please try again later.")
            {
                StatusCode = 500
            };
        }
    }
}
