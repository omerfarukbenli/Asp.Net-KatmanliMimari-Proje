using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers
{
    //burayı sildik
    public class CustomBaseController : ControllerBase
    {
        [NonAction] //end point olarak alınmasın
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response) //createactionresultu kullandık
        {
            if (response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode,
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
