using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCoreFilterDemo.Filter
{
    public class CustomerResultFilter:ResultFilterAttribute
    {
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Console.WriteLine($"This is {typeof(CustomerResultFilter)} OnActionExecuted");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Console.WriteLine($"This is {typeof(CustomerResultFilter)} OnActionExecuting");
        }

    }
}