using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace DotnetCoreFilterDemo.Filter
{
    public class CustomerExceptionFilter:ExceptionFilterAttribute
    {
        private readonly ILogger<CustomerExceptionFilter> _logger;

        public CustomerExceptionFilter(ILogger<CustomerExceptionFilter> logger)
        {
            _logger = logger;
        }
        public override void OnException(ExceptionContext context)
        {
            //if (!context.ExceptionHandled)
            //{
            //    Console.WriteLine($"{context.Exception.Message}");
            //    context.Result= new JsonResult(new
            //    {
            //        Result = false,
            //        Msg = $"{context.Exception.Message}"
            //    });
            //    context.ExceptionHandled = true;
            //    _logger.LogError(context.Exception.StackTrace);
            //}

            if (!context.ExceptionHandled)
            {
                Console.WriteLine($"{context.Exception.Message}");
                _logger.LogError(context.Exception.StackTrace);
                context.Result = new BadRequestObjectResult(context.Exception.Message);
                context.ExceptionHandled = true;
            }
            // base.OnException(context);
        }

    }
}