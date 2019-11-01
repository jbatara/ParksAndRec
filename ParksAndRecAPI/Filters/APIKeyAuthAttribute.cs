using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using ParksAndRecAPI.Models;

namespace ParksAndRecAPI.Filters {
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Method)]
    public class ApiKeyAuthAttribute : Attribute, IAsyncActionFilter {
        private const string ApiKeyHeaderName = "ApiKey";
        private const string DepartmentIdHeaderName = "DepartmentId";
        private Application

            public async Task OnActionExecutionAsync (ActionExecutingContext context, ActionExecutionDelegate next) {
                
                if (!context.HttpContext.Request.Headers.TryGetValue (ApiKeyHeaderName, out var potentialApiKey)) {
                    context.Result = new UnauthorizedResult ();
                    return;
                }

                var configuration = context.HttpContext.RequestServices.GetRequiredService<IConfiguration> ();
                var apiKey = configuration.GetValue<string> ("ApiKey");

                if (!apiKey.Equals (potentialApiKey)) {
                    context.Result = new UnauthorizedResult ();
                    return;
                }

                await next ();
            }
    }
}