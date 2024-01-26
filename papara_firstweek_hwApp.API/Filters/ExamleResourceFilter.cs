using Microsoft.AspNetCore.Mvc.Filters;

namespace papara_firstweek_hwApp.API.Filter
{
    public class ExamleResourceFilter :Attribute,  IResourceFilter

    {
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine("ExamleResourceFilter > OnResourceExecuted");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine("ExamleResourceFilter > OnResourceExecuting");
        }
    }
}
