using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExamenNetCoreApi.Filters
{
    public class AlbumResultFilterAttribute : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var resultFromAction = context.Result as ObjectResult;
            if (resultFromAction?.Value == null
                || resultFromAction.StatusCode < 200
                || resultFromAction.StatusCode < 200)
            {
                await next();
                return;
            }

            resultFromAction.Value = Mapper.Map<IEnumerable<ViewModels.Album>>(resultFromAction.Value);

            await next();
        }
    }
}
