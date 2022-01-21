using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using botcamp_practice1.Auth.concrete;
using botcamp_practice1.Controllers.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace botcamp_practice1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private  IAuthService _authService; 

        public WeatherForecastController(IAuthService authService){
            _authService = authService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var result = _authService.Auth("omer1345");
            return Ok(result);
        }
    }
}
