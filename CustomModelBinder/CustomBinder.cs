using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corewebapidemo.CustomModelBinder
{
    public class CustomBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var dataQuery = bindingContext.HttpContext.Request.Query;
            //var dataForm = bindingContext.HttpContext.Request.Form;
            //var dataCookies = bindingContext.HttpContext.Request.Cookies;

            var result = dataQuery.TryGetValue("countries", out var countries);
            if (result)
            {
                var array = countries.ToString().Split('|');
                bindingContext.Result = ModelBindingResult.Success(array);
            }
            return Task.CompletedTask;
        }
    }
}
