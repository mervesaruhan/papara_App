using Microsoft.AspNetCore.Mvc.Filters;

namespace papara_firstweek_hwApp.API.Filter
{
    public class ExampleActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("ExampleActionFilter > OnActionExecuted");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("ExampleActionFilter > OnActionExecuting");
        }
    }
}
