using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using papara_firstweek_hwApp.API.Models;
using System.Runtime.CompilerServices;

namespace papara_firstweek_hwApp.API.Filters;

public class NotFoundActionFilter(IUserRepository userRepository) : Attribute, IActionFilter
{
    private readonly IUserRepository _userRepository = userRepository;


    public void OnActionExecuting(ActionExecutingContext context)
    {

        
        var idAsObject = context.ActionArguments.FirstOrDefault(x => x.Key == "id");


        if (idAsObject.Key is null || idAsObject.Value is null) return;

        if (!int.TryParse(idAsObject.Value.ToString(), out var id)) return;

        var hasProduct = _userRepository.GetById(id);

        if (hasProduct is null) context.Result = new NotFoundObjectResult($"User not found with id {id}");


        Console.WriteLine($"User  found with id {id}"); 
        
        #region hatalı

        //önce id nin var olup olmadıgı kontrol etmediğim için buraı patlıyor
        //var idAsObject = context.ActionArguments["id"];
        //if (idAsObject is null) return;
        //if (!int.TryParse(idAsObject.ToString(), out var id)) return;
        //var hasUser = _userRepository.GetById(id);
        //if (hasUser is null) context.Result = new NotFoundObjectResult($"User not found with id {id}"); 
        #endregion

    }
    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
}



    

