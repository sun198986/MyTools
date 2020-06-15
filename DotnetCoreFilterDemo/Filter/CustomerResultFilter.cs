using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCoreFilterDemo.Filter
{
    public class CustomerResultFilter : Attribute, IAuthorizationFilter, IFilterMetadata
    {
        //public override void OnResultExecuted(ResultExecutedContext context)
        //{
        //    Console.WriteLine($"This is {typeof(CustomerResultFilter)} OnActionExecuted");
        //}

        //public override void OnResultExecuting(ResultExecutingContext context)
        //{
        //    Console.WriteLine($"This is {typeof(CustomerResultFilter)} OnActionExecuting");
        //}

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }
}