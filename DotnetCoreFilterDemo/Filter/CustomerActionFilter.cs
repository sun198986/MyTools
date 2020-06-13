using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCoreFilterDemo.Filter
{
    public class CustomerActionFilter:ActionFilterAttribute
    {
        
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            //api的验证
            Console.WriteLine($"This is {typeof(CustomerActionFilter)} OnActionExecuted");
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            
            Console.WriteLine($"This is {typeof(CustomerActionFilter)} OnActionExecuting");
        }
    }
}