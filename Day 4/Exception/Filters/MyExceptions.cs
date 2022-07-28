using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

using log4net;

namespace WebApplication1.Filters
{
    public class MyExceptions : IExceptionFilter
    {
       
       private readonly ILog _logger = LogManager.GetLogger(typeof(MyExceptions));

       public void OnException(ExceptionContext context)
       {

        _logger.Error(context.Exception.Message);
        context.ExceptionHandled = true;
        context.Result = new ViewResult() { ViewName = "_MyError" };
       }
    }
}

