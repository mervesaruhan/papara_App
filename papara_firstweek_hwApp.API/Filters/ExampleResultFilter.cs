using Microsoft.AspNetCore.Mvc.Filters;

namespace papara_firstweek_hwApp.API.Filters;

public class ExampleResultFilter : Attribute, IResultFilter
{
    public void OnResultExecuted(ResultExecutedContext context)
    {
        if (context.HttpContext.Request.Headers.Any(x => x.Key == "X-Example")) return;

        context.HttpContext.Response.Headers.Append("X-Example", "Example");
        Console.WriteLine("OnResultExecuted");
    }

    public void OnResultExecuting(ResultExecutingContext context)
    {
        Console.WriteLine("OnResultExecuting");
    }
}
