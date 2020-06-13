using System;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCoreFilterDemo.Filter
{
    public class CustomerResourceFilter : Attribute, IResourceFilter,IFilterMetadata,IOrderedFilter
    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"This is {typeof(CustomerResourceFilter)} OnActionExecuted");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"This is {typeof(CustomerResourceFilter)} OnResourceExecuting");
        }

        public int Order { get; }
    }
}