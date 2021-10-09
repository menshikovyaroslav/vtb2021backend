using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vtb_api.Classes
{
    /// <summary>
    /// Аттрибут для фронтенда
    /// </summary>
    public class AllowCrossSiteJson : ActionFilterAttribute
    {
        /// <summary>
        /// Переопределен метод для добавления заголовка
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            base.OnActionExecuting(filterContext);
        }
    }
}
